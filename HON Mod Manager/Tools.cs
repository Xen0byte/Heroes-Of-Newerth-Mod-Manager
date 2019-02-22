using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CS_ModMan
{
    internal class Tools
    {
        public static bool IsNewerVersion(string Old, string New)
        {
            if (Old == "") Old = "0";
            if (New == "") New = "0";

            int[] OldParts = StrArrayToIntArray(Old.Split('.'));
            int[] NewParts = StrArrayToIntArray(New.Split('.'));
            for (int i = 0; i <= Math.Min(OldParts.Length - 1, NewParts.Length - 1); i++)
            {
                if (OldParts[i] != NewParts[i]) return NewParts[i] > OldParts[i];
            }
            if (OldParts.Length != NewParts.Length) return NewParts.Length > OldParts.Length;
            return true;
            //if the version strings are the same, return true
        }


        public static int[] StrArrayToIntArray(string[] s)
        {
            int[] myOutput = new int[s.Length - 1];
            for (int i = 0; i < s.Length - 1; i++)
            {
                int j;
                if (int.TryParse(RemoveNonDigits(s[i]), out j))
                {
                    myOutput[i] = j;
                }
                else
                {
                    myOutput[i] = 0;
                }
            }
            return myOutput;
        }


        public static string RemoveNonDigits(string s)
        {
            if (s == "*") return int.MinValue.ToString();
            string myOutput = "";
            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (s[i] >= '0' && s[i] <= '9')
                {
                    myOutput += s[i];
                }
            }
            return myOutput;
        }

        #region " OS business "

        private static bool IsWindows()
        {
            return Environment.OSVersion.Platform == PlatformID.Win32NT;
            //includes XP, Vista and 7
        }

        public static bool IsLinux()
        {
            if (Environment.OSVersion.Platform != PlatformID.Unix) return false;
            //make sure mono isn't fooling us!
            try
            {
                return
                    !Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                                                   "Library/Application Support"));
            }
            catch
            {
                return true;
            }
        }

        public static bool IsMacOS()
        {
            if (Environment.OSVersion.Platform == PlatformID.MacOSX)
                return true;

            //might still be mac in disguise!
            if (Environment.OSVersion.Platform != PlatformID.Unix)
                return false;
            try
            {
                return
                    Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                                                  "Library/Application Support"));
            }
            catch
            {
                return false;
            }
        }

        #endregion
       
    }
}