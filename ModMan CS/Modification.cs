#region Using Directives

using System.Collections.Generic;
using System.Drawing;

#endregion

namespace CS_ModMan
{
    public class Modification
    {
        //for use with the GUI
        //<-- only accurate during UpdateList()
        //was this mod found to be applied when reading resources999.s2z?
        public bool Applied;
        public Dictionary<string, string> ApplyAfter = new Dictionary<string, string>();
        public Dictionary<string, string> ApplyBefore = new Dictionary<string, string>();
        public List<Modification> ApplyFirst = new List<Modification>();
        public string AppVersion;
        public string Author;
        public string Description;
        //full .honmod file path
        public string File;

        //e.g. "WC3 Reserve Voices: Full"
        //e.g. "wc3reservevoicesfull" (same as name, but only lowercase letters and digits; used to check for mod identity)
        public string FixedName;
        //description string to be displayed by GUI
        public Bitmap Icon;
        public int ImageListIdx;
        //required HoN version matching string ("1.5-2.*" allowed)

        //raw incompatibility, requirement and priority data
        //Key: FixedName of the incompatible mod, Value: version matching string, space character, non-fixed mod name
        public Dictionary<string, string> Incompatibilities = new Dictionary<string, string>();
        public int Index;
        //Same as Incompatibilities
        //used for cycle detection
        public bool Marked;
        public string MMVersion;
        private bool myDisabled;
        public string Name;
        public Dictionary<string, string> Requirements = new Dictionary<string, string>();


        //URL for checking for updates
        public string UpdateCheck;
        //URL for downloading newest version of the mod
        public string UpdateDownload;

        //Reference to a ModUpdater object if this mod is currently being updated
        public ModUpdater Updater;

        public string Version;
        //website link to be displayed by GUI
        public string WebLink;

        public bool Disabled
        {
            get { return myDisabled; }
            set { myDisabled = value; }
        }

        public bool Enabled
        {
            get { return !myDisabled; }
            set { myDisabled = !value; }
        }

        public bool IsUpdating
        {
            get { return !(Updater == null || Updater.Status >= ModUpdaterStatus.NoUpdateInformation); }
        }
    }
}