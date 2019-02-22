#region Using Directives

using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

#endregion

namespace CS_ModMan
{
    public class GameHelper
    {
        private static readonly byte[] WinID = new byte[]
                                                   {
                                                       0x5B, 0x00, 0x53, 0x00, 0x45, 0x00, 0x43, 0x00, 0x55, 0x00,
                                                       0x52, 0x00, 0x45, 0x00, 0x20, 0x00, 0x43, 0x00, 0x52, 0x00, 
                                                       0x54, 0x00, 0x5D, 0x00, 0x00, 0x00
                                                   };

        private static readonly byte[] LinID = new byte[]
                                                   {
                                                       0x5b, 0x00, 0x00, 0x00, 0x55, 0x00, 0x00, 0x00, 0x4e, 0x00,
                                                       0x00, 0x00, 0x49, 0x00, 0x00, 0x00, 0x43, 0x00, 0x00, 0x00,
                                                       0x4f, 0x00, 0x00, 0x00, 0x44, 0x00, 0x00, 0x00, 0x45, 0x00,
                                                       0x00, 0x00, 0x5d, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                                                   };

        private static readonly byte[] MacID = new byte[]
                                                   {
                                                       0x5b, 0x00, 0x00, 0x00, 0x55, 0x00, 0x00, 0x00, 0x4e, 0x00,
                                                       0x00, 0x00, 0x49, 0x00, 0x00, 0x00, 0x43, 0x00, 0x00, 0x00,
                                                       0x4f, 0x00, 0x00, 0x00, 0x44, 0x00, 0x00, 0x00, 0x45, 0x00,
                                                       0x00, 0x00, 0x5d, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                                                   };

        private static string s_gameFilePath;
        private static Version s_version;

        public static Version Version
        {
            get { return s_version; }
        }

        public static string GameFilePath
        {
            get { return s_gameFilePath; }
        }

        public static string GameDir
        {
            get
            {
                if (string.IsNullOrEmpty(GameFilePath))
                    return string.Empty;

                return Path.GetDirectoryName(GameFilePath);  
            }
            set {  }
        }

        public static string ModsDir
        {
            get
            {
                return s_modsDir;
            }
            set
            {
                s_modsDir = value;
            }
        }

        public static int FindInByteStream(byte[] Haystack, byte[] Needle)
        {
            //returns the first of the byte sequence Needle in the byte sequence Haystack; returns -1 if not found
            int end = Haystack.Length - Needle.Length;

            for (int i = 0; i <= end; i++)
            {
                for (int j = 0; j < Needle.Length; j++)
                {
                    if (Haystack[i + j] != Needle[j])
                        break;

                    if (j == Needle.Length - 1)
                        return i;
                }
            }

            return -1;
        }

        public static bool CheckVersion(string path)
        {
            //tries reading the current game version from the game's binaries and also registers the binary's path for the "Apply & Launch" command if successful
            
            if (!string.IsNullOrEmpty(path))
            {
                byte[] tBuffer;
                int i = -1;
                string filePath = Path.Combine(path, "hon.exe");

                if (File.Exists(filePath))
                {
                    s_gameFilePath = filePath;
                    tBuffer = File.ReadAllBytes(filePath);
                    i = FindInByteStream(tBuffer, WinID);

                    if (i >= 0)
                    {
                        i += WinID.Length;

                        int major, minor, build, revision;
                        int.TryParse(Convert.ToChar(tBuffer[i] + 256*tBuffer[i + 1]).ToString(), out major);
                        i += 4;

                        int.TryParse(Convert.ToChar(tBuffer[i] + 256 * tBuffer[i + 1]).ToString(), out minor);
                        i += 4;

                        int.TryParse(Convert.ToChar(tBuffer[i] + 256 * tBuffer[i + 1]).ToString(), out build);
                        i += 4;

                        int.TryParse(Convert.ToChar(tBuffer[i] + 256 * tBuffer[i + 1]).ToString(), out revision);
                      
                        s_version = new Version(major, minor, build, revision);
                    }
                }
                else
                {
                    filePath = Path.Combine(path, "hon-x86");
                    if (File.Exists(filePath))
                    {
                        s_gameFilePath = filePath;
                        tBuffer = File.ReadAllBytes(filePath);
                        i = FindInByteStream(tBuffer, LinID);
                    }
                    else
                    {
                        filePath = Path.Combine(path, "hon-x86_64");
                        if (File.Exists(filePath))
                        {
                            s_gameFilePath = filePath;
                            tBuffer = File.ReadAllBytes(filePath);
                            i = FindInByteStream(tBuffer, LinID);
                        }
                        else
                        {
                            tBuffer = null;
                            i = -1;
                        }
                    }

                    if (i >= 0)
                    {
                        i += LinID.Length;

                        int major, minor, build, revision;
                        int.TryParse(Convert.ToChar(tBuffer[i] + 256 * (tBuffer[i + 1] + 256 * (tBuffer[i + 2] + 256 * tBuffer[i + 3]))).ToString(), out major);
                        i += 4;

                        int.TryParse(Convert.ToChar(tBuffer[i] + 256 * (tBuffer[i + 1] + 256 * (tBuffer[i + 2] + 256 * tBuffer[i + 3]))).ToString(), out minor);
                        i += 4;

                        int.TryParse(Convert.ToChar(tBuffer[i] + 256 * (tBuffer[i + 1] + 256 * (tBuffer[i + 2] + 256 * tBuffer[i + 3]))).ToString(), out build);
                        i += 4;

                        int.TryParse(Convert.ToChar(tBuffer[i] + 256 * (tBuffer[i + 1] + 256 * (tBuffer[i + 2] + 256 * tBuffer[i + 3]))).ToString(), out revision);

                        s_version = new Version(major, minor, build, revision);
                    }
                    else
                    {
                        filePath = Path.Combine(path, "HoN");
                        if (File.Exists(filePath))
                        {
                            s_gameFilePath = filePath;
                            tBuffer = File.ReadAllBytes(filePath);
                            i = FindInByteStream(tBuffer, MacID);

                            if (i >= 0)
                            {
                                i += MacID.Length;

                                int major, minor, build, revision;
                                int.TryParse(Convert.ToChar(tBuffer[i] + 256 * (tBuffer[i + 1] + 256 * (tBuffer[i + 2] + 256 * tBuffer[i + 3]))).ToString(), out major);
                                i += 4;

                                int.TryParse(Convert.ToChar(tBuffer[i] + 256 * (tBuffer[i + 1] + 256 * (tBuffer[i + 2] + 256 * tBuffer[i + 3]))).ToString(), out minor);
                                i += 4;

                                int.TryParse(Convert.ToChar(tBuffer[i] + 256 * (tBuffer[i + 1] + 256 * (tBuffer[i + 2] + 256 * tBuffer[i + 3]))).ToString(), out build);
                                i += 4;

                                int.TryParse(Convert.ToChar(tBuffer[i] + 256 * (tBuffer[i + 1] + 256 * (tBuffer[i + 2] + 256 * tBuffer[i + 3]))).ToString(), out revision);

                                s_version = new Version(major, minor, build, revision);
                            }
                        }
                    }
                }
            }

            if (s_version == null)
            {
                MessageBox.Show(
                    "Could not detect Heroes of Newerth version. Version checks have been disabled." +
                    Environment.NewLine + Environment.NewLine + "Always close HoN before running the mod manager.",
                    "HoN Mod Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        public static bool IsValidGameDir(string Path)
        {
            //checks for existance of subfolder "game" and file "resources0.s2z" (min size 1 MB)
            if (Path == "") return false;
            try
            {
                if (!Directory.Exists(System.IO.Path.Combine(Path, "game"))) return false;
                FileInfo f = new FileInfo(System.IO.Path.Combine(Path, System.IO.Path.Combine("game", "resources0.s2z")));
                if (f.Length < 1048576) return false;
            }
            catch
            {
                return false;
            }
            return true;
        }


        public static string DetectGameDir()
        {
            //this function tries its best to find the hon install dir; it either returns a VALID hon install path or the empty string

            //first check whether we stored a dir last time
            string s = RegistryHelper.GetRegistryEntry("hondir");
            if (IsValidGameDir(s)) return s;

            if (Tools.IsLinux())
            {
                //check linux default desktop shortcut
                s = GetGameDirLinux();
                if (IsValidGameDir(s)) return s;

                //guess some common paths
                try
                {
                    s = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "Heroes of Newerth");
                    if (IsValidGameDir(s)) return s;
                }
                catch
                {
                }

                try
                {
                    s = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/HoN";
                    if (IsValidGameDir(s)) return s;
                }
                catch
                {
                }
            }
            else if (Tools.IsMacOS())
            {
                //guess some common paths
                try
                {
                    s = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "Heroes of Newerth");
                    if (IsValidGameDir(s)) return s;
                }
                catch
                {
                }

                s = "/applications/heroes of newerth.app";
                if (IsValidGameDir(s)) return s;
                s = "/Applications/Heroes of Newerth.app";
                if (IsValidGameDir(s)) return s;
            }
            //we'll treat anything else as windows
            else
            {
                //check windows registry
                s = GetGameDirWinReg();
                if (IsValidGameDir(s)) return s;

                //guess some common paths
                try
                {
                    s = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles),
                                     "Heroes of Newerth");
                    if (IsValidGameDir(s)) return s;
                }
                catch
                {
                    s = "";
                }
                if (s.ToLower().StartsWith("c:\\"))
                {
                    s = "d:\\" + s.Substring(3);
                    if (IsValidGameDir(s)) return s;
                    s = "e:\\" + s.Substring(3);
                    if (IsValidGameDir(s)) return s;
                }

                try
                {
                    s = Environment.GetEnvironmentVariable("ProgramFiles(x86)");
                    if (s == null | s == Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)) s = "";
                    if (IsValidGameDir(s)) return s;
                }
                catch
                {
                    s = "";
                }
                if (s.ToLower().StartsWith("c:\\"))
                {
                    s = "d:\\" + s.Substring(3);
                    if (IsValidGameDir(s)) return s;
                    s = "e:\\" + s.Substring(3);
                    if (IsValidGameDir(s)) return s;
                }

                s = "D:\\Heroes of Newerth";
                if (IsValidGameDir(s)) return s;
                s = "E:\\Heroes of Newerth";
                if (IsValidGameDir(s)) return s;
                s = "C:\\Games\\Heroes of Newerth";
                if (IsValidGameDir(s)) return s;
                s = "D:\\Games\\Heroes of Newerth";
                if (IsValidGameDir(s)) return s;
                s = "E:\\Games\\Heroes of Newerth";
                if (IsValidGameDir(s)) return s;
            }

            //we failed guessing it :-(
            //finally ask the user!
            FolderBrowserDialog o = new FolderBrowserDialog();
            o.Description = "I couldn't find your HoN install, please point me to the folder containing the binary!" +
                            Environment.NewLine + "Press Cancel to enter the path manually.";
            if (o.ShowDialog() == DialogResult.OK)
            {
                s = o.SelectedPath;
            }
            else
            {
                /*frmInputbox myDialog = new frmInputbox();
                myDialog.Text = "Enter HoN path manually:";
                if (myDialog.ShowDialog() == Windows.Forms.DialogResult.OK)
                {
                    s = myDialog.Result;
                }
                else
                {
                    return "";
                }*/
            }

            if (IsValidGameDir(s)) return s;

            //if the user-specified is not working either try to fix it - e.g. maybe he sent us to the game subfolder!
            s = TryFixUserPath(s);
            if (s != "") return s;

            //all hope is lost!
            return "";
        }


        private static string GetGameDirWinReg()
        {
            //tries to find the hon install dir in the windows registry's uninstall information
            try
            {
                RegistryKey r = Registry.LocalMachine;
                if (r == null) return "";
                r = r.OpenSubKey("SOFTWARE");
                if (r == null) return "";
                r = r.OpenSubKey("Microsoft");
                if (r == null) return "";
                r = r.OpenSubKey("Windows");
                if (r == null) return "";
                r = r.OpenSubKey("CurrentVersion");
                if (r == null) return "";
                r = r.OpenSubKey("Uninstall");
                if (r == null) return "";
                r = r.OpenSubKey("hon");
                if (r == null) return "";
                string s = (string)r.GetValue("InstallLocation", "");
                if (s == "") return "";
                if (Directory.Exists(s))
                {
                    string s2 = s.Replace(" Test Client", "");
                    if (s != s2 && Directory.Exists(s2))
                    {
                        return s2;
                    }
                    else
                    {
                        return s;
                    }
                }
                else
                {
                    return "";
                }
            }
            catch
            {
                return "";
            }
        }

        private static string GetGameDirLinux()
        {
            //tries to find the default hon desktop shortcut under linux
            try
            {
                StreamReader myStreamReader =
                    new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) +
                                     "/applications/s2games_com-HoN_1.desktop");
                do
                {
                    string s = myStreamReader.ReadLine();
                    if (s.StartsWith("Exec=") && s.EndsWith("/hon.sh"))
                        return s.Substring("Exec=".Length, s.Length - "Exec=".Length - "/hon.sh".Length);
                } while (!(myStreamReader.EndOfStream));
            }
            catch
            {
            }
            return "";
        }

        //e.g. "C:\Program Files\Heroes of Newerth\game" - FIXED to "~/.Heroes of Newerth/game" under linux, and to "~/Library/Application Support/Heroes of Newerth/game" under mac
        private static string m_modsDir;
        private static string s_modsDir;

        public static void SetModsDir()
        {
            if (Tools.IsLinux())
            {
                //m_modsDir = "~/.Heroes of Newerth/game"
                m_modsDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                                       ".Heroes of Newerth/game");
            }
            else if (Tools.IsMacOS())
            {
                //m_modsDir = "~/Library/Application Support/Heroes of Newerth/game"
                m_modsDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                                       "Library/Application Support/Heroes of Newerth/game");
            }
            else
            {
                m_modsDir = Path.Combine(GameDir, "game");
            }
        }

        public static string TryFixUserPath(string Path)
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Win32NT:
                    Path = Path.ToLower().Replace('/', '\\');
                    if (Path.EndsWith("\\")) Path = Path.Substring(0, Path.Length - 1);
                    if (Path.EndsWith("mods"))
                    {
                        Path = Path.Substring(0, Path.Length - 5);
                        if (IsValidGameDir(Path)) return Path;
                    }

                    if (Path.EndsWith("game"))
                    {
                        Path = Path.Substring(0, Path.Length - 5);
                        if (IsValidGameDir(Path)) return Path;
                    }
                    break;

                case PlatformID.Unix:
                case PlatformID.MacOSX:
                    Path = Path.ToLower().Replace('\\', '/');
                    if (Path.EndsWith("/")) Path = Path.Substring(0, Path.Length - 1);
                    if (Path.EndsWith("mods"))
                    {
                        Path = Path.Substring(0, Path.Length - 5);
                        if (IsValidGameDir(Path)) return Path;
                    }

                    if (Path.EndsWith("game"))
                    {
                        Path = Path.Substring(0, Path.Length - 5);
                        if (IsValidGameDir(Path)) return Path;
                    }

                    break;
            }

            return "";
        }
    }
}