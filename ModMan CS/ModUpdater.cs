#region Using Directives

using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading;

#endregion

namespace CS_ModMan
{
    public enum ModUpdaterStatus
    {
        NotBegun,
        Checking, //querying UpdateCheckURL
        Downloading, //querying UpdateDownloadURL
        NoUpdateInformation, //UpdateCheck is the empty string
        NoUpdatePresent, //UpdateCheckURL did not return a higher version number
        UpdateDownloaded, //successfully downloaded an update
        Failed, //something went wrong
        Aborted //we were asked to stop
    }

    public class ModUpdater
    {
        private bool m_abortRequested = false;
        private Modification m_mod;

        private ModUpdaterStatus m_status;

        private Thread m_thread;

        private byte[] m_bytes = null;
        private int m_progress;
        private int m_size;
        private string m_newestVersion = "";

        private bool m_reaped = false;

        public bool Reaped
        {
            get { return m_reaped; }
            set { m_reaped = value;  }
        }

        public ModUpdater(Modification mod)
        {
            m_mod = mod;
            m_thread = new Thread(UpdateThread);
            m_thread.Start();
        }

        public Modification Mod
        {
            get { return m_mod; }
        }

        public ModUpdaterStatus Status
        {
            get { return m_status; }
        }

        public string StatusString
        {
            get
            {
                switch (m_status)
                {
                    case ModUpdaterStatus.NotBegun:
                        return "Waiting";
                    case ModUpdaterStatus.Checking:
                        return "Checking for new version";
                    case ModUpdaterStatus.Downloading:
                        if (m_size > 0)
                        {
                            return "Downloaded " + (m_progress*100/m_size) + "% of " + m_size/1024 +
                                   " KB";
                        }
                        else
                        {
                            return "Downloading";
                        }

                    case ModUpdaterStatus.NoUpdateInformation:
                        return "Not updatable";
                    case ModUpdaterStatus.NoUpdatePresent:
                        return "Already up to date";
                    case ModUpdaterStatus.UpdateDownloaded:
                        return "Updated to v" + m_newestVersion;
                    case ModUpdaterStatus.Failed:
                        return "Failed";
                    case ModUpdaterStatus.Aborted:
                        return "Aborted";
                }
                return "";
            }
        }


        public string SortKey
        {
            get
            {
                string Prefix = "";
                switch (m_status)
                {
                    case ModUpdaterStatus.NoUpdatePresent:
                        Prefix = "Z";
                        break;
                    case ModUpdaterStatus.UpdateDownloaded:
                        Prefix = "A";
                        break;
                    case ModUpdaterStatus.Failed:
                        Prefix = "B";
                        break;
                    case ModUpdaterStatus.Aborted:
                        Prefix = "C";
                        break;
                }
                return Prefix + m_mod.Name + m_mod.Version;
            }
        }

        public bool UpdateDownloaded
        {
            get { return m_status == ModUpdaterStatus.UpdateDownloaded; }
        }

        public void Abort()
        {
            m_abortRequested = true;
        }

        private static string FixHTTPURL(string URL)
        {
            if (URL.StartsWith("http://") | URL.StartsWith("https://")) return URL;
            return "http://" + URL;
        }

        private void UpdateThread()
        {
            if (m_mod.UpdateCheck == "" | m_mod.UpdateDownload == "")
            {
                m_status = ModUpdaterStatus.NoUpdateInformation;
                return;
            }

            try
            {
                m_status = ModUpdaterStatus.Checking;
                HttpWebRequest myWebRequest = (HttpWebRequest) WebRequest.Create(FixHTTPURL(m_mod.UpdateCheck));
                myWebRequest.UserAgent = "HoN Mod Manager " + Assembly.GetExecutingAssembly().GetName().Version;
                HttpWebResponse myHttpWebResponse = (HttpWebResponse) myWebRequest.GetResponse();
                StreamReader myStreamReader = new StreamReader(myHttpWebResponse.GetResponseStream());
                //only read up to 20 characters
                char[] tCharBuffer = new char[19];
                Array.Resize(ref tCharBuffer, myStreamReader.ReadBlock(tCharBuffer, 0, 20));
                m_newestVersion = new string(tCharBuffer);
                myStreamReader.Close();
                myHttpWebResponse.Close();

                if (Tools.IsNewerVersion(m_newestVersion, m_mod.Version))
                {
                    m_status = ModUpdaterStatus.NoUpdatePresent;
                    return;
                }

                m_status = ModUpdaterStatus.Downloading;
                myWebRequest = (HttpWebRequest) WebRequest.Create(FixHTTPURL(m_mod.UpdateDownload));
                myWebRequest.UserAgent = "HoN Mod Manager " + Assembly.GetExecutingAssembly().GetName().Version;
                myHttpWebResponse = (HttpWebResponse) myWebRequest.GetResponse();
                //mods larger than 25 mb are ridiculous!
                if (myHttpWebResponse.ContentLength > 25*1024*1024)
                {
                    myHttpWebResponse.Close();
                    throw new Exception();
                }
                m_size = Convert.ToInt32(myHttpWebResponse.ContentLength);
                // ERROR: Not supported in C#: ReDimStatement

                int ReadAmount;
                Stream myResponseStream = myHttpWebResponse.GetResponseStream();
                do
                {
                    if (m_abortRequested)
                    {
                        myHttpWebResponse.Close();
                        m_status = ModUpdaterStatus.Aborted;
                        return;
                    }
                    ReadAmount = myResponseStream.Read(m_bytes, m_progress,
                                                       Math.Min(256, m_size - m_progress));
                    m_progress += ReadAmount;
                } while (m_size > m_progress);
                myHttpWebResponse.Close();
                if (m_progress != m_size) throw new Exception();

                FileStream myFileStream = new FileStream(m_mod.File, FileMode.Create);
                myFileStream.Write(m_bytes, 0, m_size);
                myFileStream.Close();

                m_status = ModUpdaterStatus.UpdateDownloaded;
            }
            catch
            {
                m_status = ModUpdaterStatus.Failed;
            }
        }
    }
}