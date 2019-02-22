namespace CS_ModMan
{
    partial class MainForm : System.Windows.Forms.Form
    {

        //Form overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try {
                if (disposing && components != null) {
                    components.Dispose();
                }
            }
            finally {
                base.Dispose(disposing);
            }
        }

        //Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.myListView = new System.Windows.Forms.ListView();
            this.myContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EnableDisableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EnableAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisableAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.UpdateThisModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem11 = new System.Windows.Forms.ToolStripSeparator();
            this.ExportAss2zToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.RenameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myImageList = new System.Windows.Forms.ImageList(this.components);
            this.lblName = new System.Windows.Forms.Label();
            this.cmdToggleDisabled = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.LinkLabel();
            this.myMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplyModsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplyModsAndLaunchHoNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnapplyAllModsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.UpdateAllModsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelAllUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.OpenModFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SmallIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.ShowVersionsInMainViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshModDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeHoNPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EnterHoNPathmanuallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.CLArgumentsForLaunchingHoNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem12 = new System.Windows.Forms.ToolStripSeparator();
            this.RegisterhonmodFileExtensionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ForumThreadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myStatusStrip = new System.Windows.Forms.StatusStrip();
            this.myStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.myAppVerLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.myInfoLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDisabled = new System.Windows.Forms.Label();
            this.myUpdatingTimer = new System.Windows.Forms.Timer(this.components);
            this.myEmptyContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SelectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myContextMenu.SuspendLayout();
            this.myMenuStrip.SuspendLayout();
            this.myStatusStrip.SuspendLayout();
            this.myEmptyContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // myListView
            // 
            this.myListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.myListView.ContextMenuStrip = this.myContextMenu;
            this.myListView.HideSelection = false;
            this.myListView.LargeImageList = this.myImageList;
            this.myListView.Location = new System.Drawing.Point(0, 24);
            this.myListView.Name = "myListView";
            this.myListView.Size = new System.Drawing.Size(383, 375);
            this.myListView.SmallImageList = this.myImageList;
            this.myListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.myListView.TabIndex = 0;
            this.myListView.TileSize = new System.Drawing.Size(200, 56);
            this.myListView.UseCompatibleStateImageBehavior = false;
            this.myListView.View = System.Windows.Forms.View.List;
            this.myListView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.myListView_AfterLabelEdit);
            this.myListView.DoubleClick += new System.EventHandler(this.myListView_DoubleClick);
            this.myListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.myListView_KeyDown);
            // 
            // myContextMenu
            // 
            this.myContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EnableDisableToolStripMenuItem,
            this.EnableAllToolStripMenuItem,
            this.DisableAllToolStripMenuItem,
            this.ToolStripMenuItem3,
            this.UpdateThisModToolStripMenuItem,
            this.CancelUpdateToolStripMenuItem,
            this.ToolStripMenuItem11,
            this.ExportAss2zToolStripMenuItem,
            this.ToolStripMenuItem10,
            this.RenameToolStripMenuItem,
            this.ResetNameToolStripMenuItem,
            this.ToolStripMenuItem4,
            this.DeleteToolStripMenuItem});
            this.myContextMenu.Name = "myContextMenu";
            this.myContextMenu.Size = new System.Drawing.Size(205, 248);
            this.myContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.myContextMenu_Opening);
            // 
            // EnableDisableToolStripMenuItem
            // 
            this.EnableDisableToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EnableDisableToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnableDisableToolStripMenuItem.Name = "EnableDisableToolStripMenuItem";
            this.EnableDisableToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.EnableDisableToolStripMenuItem.Text = "En&able / Disable";
            this.EnableDisableToolStripMenuItem.Click += new System.EventHandler(this.EnableDisableToolStripMenuItem_Click);
            // 
            // EnableAllToolStripMenuItem
            // 
            this.EnableAllToolStripMenuItem.Name = "EnableAllToolStripMenuItem";
            this.EnableAllToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.EnableAllToolStripMenuItem.Text = "&Enable these Mods";
            this.EnableAllToolStripMenuItem.Visible = false;
            this.EnableAllToolStripMenuItem.Click += new System.EventHandler(this.EnableAllToolStripMenuItem_Click);
            // 
            // DisableAllToolStripMenuItem
            // 
            this.DisableAllToolStripMenuItem.Name = "DisableAllToolStripMenuItem";
            this.DisableAllToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.DisableAllToolStripMenuItem.Text = "&Disable these Mods";
            this.DisableAllToolStripMenuItem.Visible = false;
            this.DisableAllToolStripMenuItem.Click += new System.EventHandler(this.DisableAllToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem3
            // 
            this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            this.ToolStripMenuItem3.Size = new System.Drawing.Size(201, 6);
            // 
            // UpdateThisModToolStripMenuItem
            // 
            this.UpdateThisModToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UpdateThisModToolStripMenuItem.Name = "UpdateThisModToolStripMenuItem";
            this.UpdateThisModToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.UpdateThisModToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.UpdateThisModToolStripMenuItem.Text = "&Update this Mod";
            this.UpdateThisModToolStripMenuItem.Click += new System.EventHandler(this.UpdateThisModToolStripMenuItem_Click);
            // 
            // CancelUpdateToolStripMenuItem
            // 
            this.CancelUpdateToolStripMenuItem.Name = "CancelUpdateToolStripMenuItem";
            this.CancelUpdateToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.CancelUpdateToolStripMenuItem.Text = "Cancel &Update";
            this.CancelUpdateToolStripMenuItem.Visible = false;
            this.CancelUpdateToolStripMenuItem.Click += new System.EventHandler(this.CancelUpdateToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem11
            // 
            this.ToolStripMenuItem11.Name = "ToolStripMenuItem11";
            this.ToolStripMenuItem11.Size = new System.Drawing.Size(201, 6);
            // 
            // ExportAss2zToolStripMenuItem
            // 
            this.ExportAss2zToolStripMenuItem.Name = "ExportAss2zToolStripMenuItem";
            this.ExportAss2zToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.ExportAss2zToolStripMenuItem.Text = "Export as .s2&z ...";
            this.ExportAss2zToolStripMenuItem.Click += new System.EventHandler(this.ExportAss2zToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem10
            // 
            this.ToolStripMenuItem10.Name = "ToolStripMenuItem10";
            this.ToolStripMenuItem10.Size = new System.Drawing.Size(201, 6);
            // 
            // RenameToolStripMenuItem
            // 
            this.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem";
            this.RenameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.RenameToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.RenameToolStripMenuItem.Text = "Re&name";
            this.RenameToolStripMenuItem.Click += new System.EventHandler(this.RenameToolStripMenuItem_Click);
            // 
            // ResetNameToolStripMenuItem
            // 
            this.ResetNameToolStripMenuItem.Name = "ResetNameToolStripMenuItem";
            this.ResetNameToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.ResetNameToolStripMenuItem.Text = "&Reset Name";
            this.ResetNameToolStripMenuItem.Visible = false;
            this.ResetNameToolStripMenuItem.Click += new System.EventHandler(this.ResetNameToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem4
            // 
            this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
            this.ToolStripMenuItem4.Size = new System.Drawing.Size(201, 6);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.DeleteToolStripMenuItem.Text = "&Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // myImageList
            // 
            this.myImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.myImageList.ImageSize = new System.Drawing.Size(48, 48);
            this.myImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(389, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 1;
            this.lblName.UseMnemonic = false;
            // 
            // cmdToggleDisabled
            // 
            this.cmdToggleDisabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdToggleDisabled.Location = new System.Drawing.Point(480, 359);
            this.cmdToggleDisabled.Name = "cmdToggleDisabled";
            this.cmdToggleDisabled.Size = new System.Drawing.Size(79, 35);
            this.cmdToggleDisabled.TabIndex = 4;
            this.cmdToggleDisabled.UseVisualStyleBackColor = true;
            this.cmdToggleDisabled.Visible = false;
            this.cmdToggleDisabled.Click += new System.EventHandler(this.cmdToggleDisabled_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.Location = new System.Drawing.Point(389, 46);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(170, 313);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.UseMnemonic = false;
            this.lblDescription.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDescription_LinkClicked);
            // 
            // myMenuStrip
            // 
            this.myMenuStrip.GripMargin = new System.Windows.Forms.Padding(2);
            this.myMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ViewToolStripMenuItem,
            this.OptionsToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.myMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.myMenuStrip.Name = "myMenuStrip";
            this.myMenuStrip.Size = new System.Drawing.Size(564, 24);
            this.myMenuStrip.TabIndex = 6;
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ApplyModsToolStripMenuItem,
            this.ApplyModsAndLaunchHoNToolStripMenuItem,
            this.UnapplyAllModsToolStripMenuItem,
            this.ToolStripMenuItem1,
            this.UpdateAllModsToolStripMenuItem,
            this.CancelAllUpdatesToolStripMenuItem,
            this.ToolStripMenuItem5,
            this.OpenModFolderToolStripMenuItem,
            this.ToolStripMenuItem6,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "&File";
            // 
            // ApplyModsToolStripMenuItem
            // 
            this.ApplyModsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ApplyModsToolStripMenuItem.Name = "ApplyModsToolStripMenuItem";
            this.ApplyModsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.ApplyModsToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.ApplyModsToolStripMenuItem.Text = "&Apply Mods";
            this.ApplyModsToolStripMenuItem.Click += new System.EventHandler(this.ApplyModsToolStripMenuItem_Click);
            // 
            // ApplyModsAndLaunchHoNToolStripMenuItem
            // 
            this.ApplyModsAndLaunchHoNToolStripMenuItem.Enabled = false;
            this.ApplyModsAndLaunchHoNToolStripMenuItem.Name = "ApplyModsAndLaunchHoNToolStripMenuItem";
            this.ApplyModsAndLaunchHoNToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                        | System.Windows.Forms.Keys.S)));
            this.ApplyModsAndLaunchHoNToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.ApplyModsAndLaunchHoNToolStripMenuItem.Text = "Apply Mods and &Launch HoN";
            this.ApplyModsAndLaunchHoNToolStripMenuItem.Click += new System.EventHandler(this.ApplyModsAndLaunchHoNToolStripMenuItem_Click);
            // 
            // UnapplyAllModsToolStripMenuItem
            // 
            this.UnapplyAllModsToolStripMenuItem.Name = "UnapplyAllModsToolStripMenuItem";
            this.UnapplyAllModsToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.UnapplyAllModsToolStripMenuItem.Text = "U&napply All Mods";
            this.UnapplyAllModsToolStripMenuItem.Click += new System.EventHandler(this.UnapplyAllModsToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(291, 6);
            // 
            // UpdateAllModsToolStripMenuItem
            // 
            this.UpdateAllModsToolStripMenuItem.Name = "UpdateAllModsToolStripMenuItem";
            this.UpdateAllModsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.U)));
            this.UpdateAllModsToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.UpdateAllModsToolStripMenuItem.Text = "Download Mod &Updates";
            this.UpdateAllModsToolStripMenuItem.Click += new System.EventHandler(this.UpdateAllModsToolStripMenuItem_Click);
            // 
            // CancelAllUpdatesToolStripMenuItem
            // 
            this.CancelAllUpdatesToolStripMenuItem.Name = "CancelAllUpdatesToolStripMenuItem";
            this.CancelAllUpdatesToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.CancelAllUpdatesToolStripMenuItem.Text = "&Cancel All Updates";
            this.CancelAllUpdatesToolStripMenuItem.Visible = false;
            this.CancelAllUpdatesToolStripMenuItem.Click += new System.EventHandler(this.CancelAllUpdatesToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem5
            // 
            this.ToolStripMenuItem5.Name = "ToolStripMenuItem5";
            this.ToolStripMenuItem5.Size = new System.Drawing.Size(291, 6);
            // 
            // OpenModFolderToolStripMenuItem
            // 
            this.OpenModFolderToolStripMenuItem.Name = "OpenModFolderToolStripMenuItem";
            this.OpenModFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.OpenModFolderToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.OpenModFolderToolStripMenuItem.Text = "&Open Mod Folder";
            this.OpenModFolderToolStripMenuItem.Click += new System.EventHandler(this.OpenModFolderToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem6
            // 
            this.ToolStripMenuItem6.Name = "ToolStripMenuItem6";
            this.ToolStripMenuItem6.Size = new System.Drawing.Size(291, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.ExitToolStripMenuItem.Text = "E&xit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // ViewToolStripMenuItem
            // 
            this.ViewToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListToolStripMenuItem,
            this.SmallIconsToolStripMenuItem,
            this.TilesToolStripMenuItem,
            this.ToolStripMenuItem7,
            this.ShowVersionsInMainViewToolStripMenuItem,
            this.ToolStripMenuItem9,
            this.RefreshModDisplayToolStripMenuItem});
            this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            this.ViewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ViewToolStripMenuItem.Text = "&View";
            // 
            // ListToolStripMenuItem
            // 
            this.ListToolStripMenuItem.Checked = true;
            this.ListToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ListToolStripMenuItem.Name = "ListToolStripMenuItem";
            this.ListToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.ListToolStripMenuItem.Text = "&Vertical List";
            this.ListToolStripMenuItem.Click += new System.EventHandler(this.ListToolStripMenuItem_Click);
            // 
            // SmallIconsToolStripMenuItem
            // 
            this.SmallIconsToolStripMenuItem.Name = "SmallIconsToolStripMenuItem";
            this.SmallIconsToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.SmallIconsToolStripMenuItem.Text = "&Horizontal List";
            this.SmallIconsToolStripMenuItem.Click += new System.EventHandler(this.SmallIconsToolStripMenuItem_Click);
            // 
            // TilesToolStripMenuItem
            // 
            this.TilesToolStripMenuItem.Name = "TilesToolStripMenuItem";
            this.TilesToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.TilesToolStripMenuItem.Text = "&Tiles";
            this.TilesToolStripMenuItem.Click += new System.EventHandler(this.TilesToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem7
            // 
            this.ToolStripMenuItem7.Name = "ToolStripMenuItem7";
            this.ToolStripMenuItem7.Size = new System.Drawing.Size(218, 6);
            // 
            // ShowVersionsInMainViewToolStripMenuItem
            // 
            this.ShowVersionsInMainViewToolStripMenuItem.Name = "ShowVersionsInMainViewToolStripMenuItem";
            this.ShowVersionsInMainViewToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.ShowVersionsInMainViewToolStripMenuItem.Text = "Show Vers&ions in Main View";
            this.ShowVersionsInMainViewToolStripMenuItem.Click += new System.EventHandler(this.ShowVersionsInMainViewToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem9
            // 
            this.ToolStripMenuItem9.Name = "ToolStripMenuItem9";
            this.ToolStripMenuItem9.Size = new System.Drawing.Size(218, 6);
            // 
            // RefreshModDisplayToolStripMenuItem
            // 
            this.RefreshModDisplayToolStripMenuItem.Name = "RefreshModDisplayToolStripMenuItem";
            this.RefreshModDisplayToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.RefreshModDisplayToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.RefreshModDisplayToolStripMenuItem.Text = "&Refresh Mod Display";
            this.RefreshModDisplayToolStripMenuItem.Click += new System.EventHandler(this.RefreshModDisplayToolStripMenuItem_Click);
            // 
            // OptionsToolStripMenuItem
            // 
            this.OptionsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeHoNPathToolStripMenuItem,
            this.EnterHoNPathmanuallyToolStripMenuItem,
            this.ToolStripMenuItem8,
            this.CLArgumentsForLaunchingHoNToolStripMenuItem,
            this.ToolStripMenuItem12,
            this.RegisterhonmodFileExtensionToolStripMenuItem});
            this.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
            this.OptionsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.OptionsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.OptionsToolStripMenuItem.Text = "&Options";
            // 
            // ChangeHoNPathToolStripMenuItem
            // 
            this.ChangeHoNPathToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ChangeHoNPathToolStripMenuItem.Name = "ChangeHoNPathToolStripMenuItem";
            this.ChangeHoNPathToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.ChangeHoNPathToolStripMenuItem.Text = "Change HoN &Path ...";
            this.ChangeHoNPathToolStripMenuItem.Click += new System.EventHandler(this.ChangeHoNPathToolStripMenuItem_Click);
            // 
            // EnterHoNPathmanuallyToolStripMenuItem
            // 
            this.EnterHoNPathmanuallyToolStripMenuItem.Name = "EnterHoNPathmanuallyToolStripMenuItem";
            this.EnterHoNPathmanuallyToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.EnterHoNPathmanuallyToolStripMenuItem.Text = "Enter HoN Path &manually ...";
            this.EnterHoNPathmanuallyToolStripMenuItem.Click += new System.EventHandler(this.EnterHoNPathmanuallyToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem8
            // 
            this.ToolStripMenuItem8.Name = "ToolStripMenuItem8";
            this.ToolStripMenuItem8.Size = new System.Drawing.Size(261, 6);
            // 
            // CLArgumentsForLaunchingHoNToolStripMenuItem
            // 
            this.CLArgumentsForLaunchingHoNToolStripMenuItem.Name = "CLArgumentsForLaunchingHoNToolStripMenuItem";
            this.CLArgumentsForLaunchingHoNToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.CLArgumentsForLaunchingHoNToolStripMenuItem.Text = "CL Arguments for launching HoN ...";
            this.CLArgumentsForLaunchingHoNToolStripMenuItem.Click += new System.EventHandler(this.CLArgumentsForLaunchingHoNToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem12
            // 
            this.ToolStripMenuItem12.Name = "ToolStripMenuItem12";
            this.ToolStripMenuItem12.Size = new System.Drawing.Size(261, 6);
            // 
            // RegisterhonmodFileExtensionToolStripMenuItem
            // 
            this.RegisterhonmodFileExtensionToolStripMenuItem.Name = "RegisterhonmodFileExtensionToolStripMenuItem";
            this.RegisterhonmodFileExtensionToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.RegisterhonmodFileExtensionToolStripMenuItem.Text = "Register .honmod File Extension";
            this.RegisterhonmodFileExtensionToolStripMenuItem.Click += new System.EventHandler(this.RegisterhonmodFileExtensionToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ForumThreadToolStripMenuItem,
            this.ToolStripMenuItem2,
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "&Help";
            // 
            // ForumThreadToolStripMenuItem
            // 
            this.ForumThreadToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ForumThreadToolStripMenuItem.Name = "ForumThreadToolStripMenuItem";
            this.ForumThreadToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.ForumThreadToolStripMenuItem.Text = "&Visit Website (Forum Thread)";
            this.ForumThreadToolStripMenuItem.Click += new System.EventHandler(this.ForumThreadToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(224, 6);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.AboutToolStripMenuItem.Text = "&About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // myStatusStrip
            // 
            this.myStatusStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.myStatusStrip.AutoSize = false;
            this.myStatusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.myStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myStatusLabel,
            this.myAppVerLabel,
            this.myInfoLabel});
            this.myStatusStrip.Location = new System.Drawing.Point(0, 399);
            this.myStatusStrip.Name = "myStatusStrip";
            this.myStatusStrip.Size = new System.Drawing.Size(564, 20);
            this.myStatusStrip.TabIndex = 5;
            // 
            // myStatusLabel
            // 
            this.myStatusLabel.AutoSize = false;
            this.myStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.myStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.myStatusLabel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.myStatusLabel.Name = "myStatusLabel";
            this.myStatusLabel.Size = new System.Drawing.Size(541, 18);
            this.myStatusLabel.Spring = true;
            this.myStatusLabel.Text = "Ready.";
            this.myStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // myAppVerLabel
            // 
            this.myAppVerLabel.ActiveLinkColor = System.Drawing.Color.Red;
            this.myAppVerLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.myAppVerLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.myAppVerLabel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.myAppVerLabel.Name = "myAppVerLabel";
            this.myAppVerLabel.Size = new System.Drawing.Size(4, 18);
            // 
            // myInfoLabel
            // 
            this.myInfoLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.myInfoLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.myInfoLabel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.myInfoLabel.Name = "myInfoLabel";
            this.myInfoLabel.Size = new System.Drawing.Size(4, 18);
            this.myInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDisabled
            // 
            this.lblDisabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisabled.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisabled.Location = new System.Drawing.Point(389, 359);
            this.lblDisabled.Name = "lblDisabled";
            this.lblDisabled.Size = new System.Drawing.Size(85, 35);
            this.lblDisabled.TabIndex = 3;
            this.lblDisabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDisabled.UseMnemonic = false;
            this.lblDisabled.Visible = false;
            // 
            // myUpdatingTimer
            // 
            this.myUpdatingTimer.Tick += new System.EventHandler(this.myUpdatingTimer_Tick);
            // 
            // myEmptyContextMenu
            // 
            this.myEmptyContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectAllToolStripMenuItem});
            this.myEmptyContextMenu.Name = "myEmptyContextMenu";
            this.myEmptyContextMenu.Size = new System.Drawing.Size(165, 26);
            // 
            // SelectAllToolStripMenuItem
            // 
            this.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem";
            this.SelectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.SelectAllToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.SelectAllToolStripMenuItem.Text = "Select &All";
            this.SelectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 418);
            this.Controls.Add(this.lblDisabled);
            this.Controls.Add(this.myStatusStrip);
            this.Controls.Add(this.cmdToggleDisabled);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.myListView);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.myMenuStrip);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.myMenuStrip;
            this.MinimumSize = new System.Drawing.Size(446, 165);
            this.Name = "Main";
            this.Text = "HoN Mod Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.myContextMenu.ResumeLayout(false);
            this.myMenuStrip.ResumeLayout(false);
            this.myMenuStrip.PerformLayout();
            this.myStatusStrip.ResumeLayout(false);
            this.myStatusStrip.PerformLayout();
            this.myEmptyContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal System.Windows.Forms.ListView myListView;
        internal System.Windows.Forms.ImageList myImageList;
        internal System.Windows.Forms.Label lblName;
        internal System.Windows.Forms.Button cmdToggleDisabled;
        internal System.Windows.Forms.LinkLabel lblDescription;
        internal System.Windows.Forms.MenuStrip myMenuStrip;
        internal System.Windows.Forms.StatusStrip myStatusStrip;
        internal System.Windows.Forms.ToolStripMenuItem OptionsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ChangeHoNPathToolStripMenuItem;
        internal System.Windows.Forms.ToolStripStatusLabel myStatusLabel;
        internal System.Windows.Forms.ToolStripStatusLabel myInfoLabel;
        internal System.Windows.Forms.ToolStripStatusLabel myAppVerLabel;
        internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ApplyModsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ForumThreadToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem2;
        internal System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        internal System.Windows.Forms.Label lblDisabled;
        internal System.Windows.Forms.ToolStripMenuItem ApplyModsAndLaunchHoNToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EnterHoNPathmanuallyToolStripMenuItem;
        internal System.Windows.Forms.ContextMenuStrip myContextMenu;
        internal System.Windows.Forms.ToolStripMenuItem EnableDisableToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem3;
        internal System.Windows.Forms.ToolStripMenuItem UpdateThisModToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem4;
        internal System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem OpenModFolderToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem6;
        internal System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RefreshModDisplayToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem UpdateAllModsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem5;
        internal System.Windows.Forms.ToolStripMenuItem UnapplyAllModsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CancelAllUpdatesToolStripMenuItem;
        internal System.Windows.Forms.Timer myUpdatingTimer;
        internal System.Windows.Forms.ToolStripMenuItem ListToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem TilesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SmallIconsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem7;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem8;
        internal System.Windows.Forms.ToolStripMenuItem CLArgumentsForLaunchingHoNToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem9;
        internal System.Windows.Forms.ToolStripMenuItem ShowVersionsInMainViewToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem10;
        internal System.Windows.Forms.ToolStripMenuItem RenameToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ResetNameToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CancelUpdateToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EnableAllToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DisableAllToolStripMenuItem;
        internal System.Windows.Forms.ContextMenuStrip myEmptyContextMenu;
        internal System.Windows.Forms.ToolStripMenuItem SelectAllToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem11;
        internal System.Windows.Forms.ToolStripMenuItem ExportAss2zToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem12;
        internal System.Windows.Forms.ToolStripMenuItem RegisterhonmodFileExtensionToolStripMenuItem;

    }
}