namespace netbioRDTx
{
    partial class Frm_Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.BAR_STAT = new System.Windows.Forms.StatusStrip();
            this.LBL_PROGRESS = new System.Windows.Forms.ToolStripStatusLabel();
            this.LBL_RDT_SIZE = new System.Windows.Forms.ToolStripStatusLabel();
            this.LBL_RDT_NAME = new System.Windows.Forms.ToolStripStatusLabel();
            this.MNU_MAIN = new System.Windows.Forms.MenuStrip();
            this.M_FILE = new System.Windows.Forms.ToolStripMenuItem();
            this.M_FILE_OPEN = new System.Windows.Forms.ToolStripMenuItem();
            this.M_FILE_SHOW_WIP = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.M_FILE_EXTRACT = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.M_FILE_REBUILD = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.M_FILE_EXIT = new System.Windows.Forms.ToolStripMenuItem();
            this.M_TOOLS = new System.Windows.Forms.ToolStripMenuItem();
            this.M_TOOLS_CLEAR_LOG = new System.Windows.Forms.ToolStripMenuItem();
            this.M_HELP = new System.Windows.Forms.ToolStripMenuItem();
            this.M_HELP_ABOUT = new System.Windows.Forms.ToolStripMenuItem();
            this.LST_TOC = new System.Windows.Forms.ListView();
            this.CLM_IDX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLM_OFFSET = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLM_SIZE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLM_TYPE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LST_LOG = new System.Windows.Forms.ListBox();
            this.BAR_TOOL = new System.Windows.Forms.ToolStrip();
            this.BTN_FILE_OPEN = new System.Windows.Forms.ToolStripButton();
            this.TBAR_SEP0 = new System.Windows.Forms.ToolStripSeparator();
            this.BTN_FILE_EXTRACT = new System.Windows.Forms.ToolStripButton();
            this.TBAR_SEP1 = new System.Windows.Forms.ToolStripSeparator();
            this.BTN_FILE_REBUILD = new System.Windows.Forms.ToolStripButton();
            this.TBAR_SEP2 = new System.Windows.Forms.ToolStripLabel();
            this.BTN_WIP_FOLDER = new System.Windows.Forms.ToolStripButton();
            this.TBAR_SEP3 = new System.Windows.Forms.ToolStripLabel();
            this.BTN_CLEAR_LOG = new System.Windows.Forms.ToolStripButton();
            this.DLG_FILE_OPEN = new System.Windows.Forms.OpenFileDialog();
            this.DLG_FOLDER = new System.Windows.Forms.FolderBrowserDialog();
            this.BAR_STAT.SuspendLayout();
            this.MNU_MAIN.SuspendLayout();
            this.BAR_TOOL.SuspendLayout();
            this.SuspendLayout();
            // 
            // BAR_STAT
            // 
            this.BAR_STAT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LBL_PROGRESS,
            this.LBL_RDT_SIZE,
            this.LBL_RDT_NAME});
            this.BAR_STAT.Location = new System.Drawing.Point(0, 666);
            this.BAR_STAT.Name = "BAR_STAT";
            this.BAR_STAT.Size = new System.Drawing.Size(884, 23);
            this.BAR_STAT.SizingGrip = false;
            this.BAR_STAT.TabIndex = 0;
            this.BAR_STAT.Text = "statusStrip1";
            // 
            // LBL_PROGRESS
            // 
            this.LBL_PROGRESS.AutoSize = false;
            this.LBL_PROGRESS.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.LBL_PROGRESS.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.LBL_PROGRESS.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_PROGRESS.Name = "LBL_PROGRESS";
            this.LBL_PROGRESS.Size = new System.Drawing.Size(158, 18);
            this.LBL_PROGRESS.Text = "Idle";
            // 
            // LBL_RDT_SIZE
            // 
            this.LBL_RDT_SIZE.AutoSize = false;
            this.LBL_RDT_SIZE.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.LBL_RDT_SIZE.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.LBL_RDT_SIZE.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_RDT_SIZE.Name = "LBL_RDT_SIZE";
            this.LBL_RDT_SIZE.Size = new System.Drawing.Size(64, 18);
            this.LBL_RDT_SIZE.Text = "0";
            // 
            // LBL_RDT_NAME
            // 
            this.LBL_RDT_NAME.AutoSize = false;
            this.LBL_RDT_NAME.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.LBL_RDT_NAME.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.LBL_RDT_NAME.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_RDT_NAME.Name = "LBL_RDT_NAME";
            this.LBL_RDT_NAME.Size = new System.Drawing.Size(660, 18);
            // 
            // MNU_MAIN
            // 
            this.MNU_MAIN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.M_FILE,
            this.M_TOOLS,
            this.M_HELP});
            this.MNU_MAIN.Location = new System.Drawing.Point(0, 0);
            this.MNU_MAIN.Name = "MNU_MAIN";
            this.MNU_MAIN.Size = new System.Drawing.Size(884, 24);
            this.MNU_MAIN.TabIndex = 1;
            this.MNU_MAIN.Text = "menuStrip1";
            // 
            // M_FILE
            // 
            this.M_FILE.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.M_FILE_OPEN,
            this.M_FILE_SHOW_WIP,
            this.toolStripMenuItem1,
            this.M_FILE_EXTRACT,
            this.toolStripMenuItem2,
            this.M_FILE_REBUILD,
            this.toolStripMenuItem3,
            this.M_FILE_EXIT});
            this.M_FILE.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M_FILE.Name = "M_FILE";
            this.M_FILE.Size = new System.Drawing.Size(48, 20);
            this.M_FILE.Text = "File";
            // 
            // M_FILE_OPEN
            // 
            this.M_FILE_OPEN.Image = ((System.Drawing.Image)(resources.GetObject("M_FILE_OPEN.Image")));
            this.M_FILE_OPEN.Name = "M_FILE_OPEN";
            this.M_FILE_OPEN.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.M_FILE_OPEN.Size = new System.Drawing.Size(203, 22);
            this.M_FILE_OPEN.Text = "Open...";
            this.M_FILE_OPEN.Click += new System.EventHandler(this.M_FILE_OPEN_Click);
            // 
            // M_FILE_SHOW_WIP
            // 
            this.M_FILE_SHOW_WIP.Image = ((System.Drawing.Image)(resources.GetObject("M_FILE_SHOW_WIP.Image")));
            this.M_FILE_SHOW_WIP.Name = "M_FILE_SHOW_WIP";
            this.M_FILE_SHOW_WIP.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.M_FILE_SHOW_WIP.Size = new System.Drawing.Size(203, 22);
            this.M_FILE_SHOW_WIP.Text = "Show WIP folder";
            this.M_FILE_SHOW_WIP.Click += new System.EventHandler(this.M_FILE_SHOW_WIP_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(200, 6);
            // 
            // M_FILE_EXTRACT
            // 
            this.M_FILE_EXTRACT.Enabled = false;
            this.M_FILE_EXTRACT.Image = ((System.Drawing.Image)(resources.GetObject("M_FILE_EXTRACT.Image")));
            this.M_FILE_EXTRACT.Name = "M_FILE_EXTRACT";
            this.M_FILE_EXTRACT.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.M_FILE_EXTRACT.Size = new System.Drawing.Size(203, 22);
            this.M_FILE_EXTRACT.Text = "Extract...";
            this.M_FILE_EXTRACT.Click += new System.EventHandler(this.M_FILE_EXTRACT_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(200, 6);
            // 
            // M_FILE_REBUILD
            // 
            this.M_FILE_REBUILD.Image = ((System.Drawing.Image)(resources.GetObject("M_FILE_REBUILD.Image")));
            this.M_FILE_REBUILD.Name = "M_FILE_REBUILD";
            this.M_FILE_REBUILD.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.M_FILE_REBUILD.Size = new System.Drawing.Size(203, 22);
            this.M_FILE_REBUILD.Text = "Rebuild...";
            this.M_FILE_REBUILD.Click += new System.EventHandler(this.M_FILE_REBUILD_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(200, 6);
            // 
            // M_FILE_EXIT
            // 
            this.M_FILE_EXIT.Image = ((System.Drawing.Image)(resources.GetObject("M_FILE_EXIT.Image")));
            this.M_FILE_EXIT.Name = "M_FILE_EXIT";
            this.M_FILE_EXIT.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.M_FILE_EXIT.Size = new System.Drawing.Size(203, 22);
            this.M_FILE_EXIT.Text = "Exit";
            this.M_FILE_EXIT.Click += new System.EventHandler(this.M_FILE_EXIT_Click);
            // 
            // M_TOOLS
            // 
            this.M_TOOLS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.M_TOOLS_CLEAR_LOG});
            this.M_TOOLS.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M_TOOLS.Name = "M_TOOLS";
            this.M_TOOLS.Size = new System.Drawing.Size(55, 20);
            this.M_TOOLS.Text = "Tools";
            // 
            // M_TOOLS_CLEAR_LOG
            // 
            this.M_TOOLS_CLEAR_LOG.Image = ((System.Drawing.Image)(resources.GetObject("M_TOOLS_CLEAR_LOG.Image")));
            this.M_TOOLS_CLEAR_LOG.Name = "M_TOOLS_CLEAR_LOG";
            this.M_TOOLS_CLEAR_LOG.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.M_TOOLS_CLEAR_LOG.Size = new System.Drawing.Size(161, 22);
            this.M_TOOLS_CLEAR_LOG.Text = "Clear log";
            this.M_TOOLS_CLEAR_LOG.Click += new System.EventHandler(this.M_TOOLS_CLEAR_LOG_Click);
            // 
            // M_HELP
            // 
            this.M_HELP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.M_HELP_ABOUT});
            this.M_HELP.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M_HELP.Name = "M_HELP";
            this.M_HELP.Size = new System.Drawing.Size(27, 20);
            this.M_HELP.Text = "?";
            // 
            // M_HELP_ABOUT
            // 
            this.M_HELP_ABOUT.Image = ((System.Drawing.Image)(resources.GetObject("M_HELP_ABOUT.Image")));
            this.M_HELP_ABOUT.Name = "M_HELP_ABOUT";
            this.M_HELP_ABOUT.Size = new System.Drawing.Size(132, 22);
            this.M_HELP_ABOUT.Text = "About...";
            this.M_HELP_ABOUT.Click += new System.EventHandler(this.M_HELP_ABOUT_Click);
            // 
            // LST_TOC
            // 
            this.LST_TOC.BackColor = System.Drawing.Color.White;
            this.LST_TOC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CLM_IDX,
            this.CLM_OFFSET,
            this.CLM_SIZE,
            this.CLM_TYPE});
            this.LST_TOC.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LST_TOC.FullRowSelect = true;
            this.LST_TOC.GridLines = true;
            this.LST_TOC.Location = new System.Drawing.Point(0, 58);
            this.LST_TOC.MultiSelect = false;
            this.LST_TOC.Name = "LST_TOC";
            this.LST_TOC.Size = new System.Drawing.Size(288, 604);
            this.LST_TOC.TabIndex = 2;
            this.LST_TOC.UseCompatibleStateImageBehavior = false;
            this.LST_TOC.View = System.Windows.Forms.View.Details;
            // 
            // CLM_IDX
            // 
            this.CLM_IDX.Text = "Index";
            // 
            // CLM_OFFSET
            // 
            this.CLM_OFFSET.Text = "Offset";
            this.CLM_OFFSET.Width = 64;
            // 
            // CLM_SIZE
            // 
            this.CLM_SIZE.Text = "Size";
            this.CLM_SIZE.Width = 64;
            // 
            // CLM_TYPE
            // 
            this.CLM_TYPE.Text = "Format";
            this.CLM_TYPE.Width = 80;
            // 
            // LST_LOG
            // 
            this.LST_LOG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.LST_LOG.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LST_LOG.ForeColor = System.Drawing.Color.LightCyan;
            this.LST_LOG.FormattingEnabled = true;
            this.LST_LOG.ItemHeight = 16;
            this.LST_LOG.Location = new System.Drawing.Point(294, 58);
            this.LST_LOG.Name = "LST_LOG";
            this.LST_LOG.Size = new System.Drawing.Size(590, 612);
            this.LST_LOG.TabIndex = 3;
            // 
            // BAR_TOOL
            // 
            this.BAR_TOOL.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.BAR_TOOL.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTN_FILE_OPEN,
            this.TBAR_SEP0,
            this.BTN_FILE_EXTRACT,
            this.TBAR_SEP1,
            this.BTN_FILE_REBUILD,
            this.TBAR_SEP2,
            this.BTN_WIP_FOLDER,
            this.TBAR_SEP3,
            this.BTN_CLEAR_LOG});
            this.BAR_TOOL.Location = new System.Drawing.Point(0, 24);
            this.BAR_TOOL.Name = "BAR_TOOL";
            this.BAR_TOOL.Size = new System.Drawing.Size(884, 31);
            this.BAR_TOOL.TabIndex = 4;
            this.BAR_TOOL.Text = "toolStrip1";
            // 
            // BTN_FILE_OPEN
            // 
            this.BTN_FILE_OPEN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BTN_FILE_OPEN.Image = ((System.Drawing.Image)(resources.GetObject("BTN_FILE_OPEN.Image")));
            this.BTN_FILE_OPEN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_FILE_OPEN.Name = "BTN_FILE_OPEN";
            this.BTN_FILE_OPEN.Size = new System.Drawing.Size(28, 28);
            this.BTN_FILE_OPEN.Text = "toolStripButton1";
            this.BTN_FILE_OPEN.ToolTipText = "Open file... (CTRL+O)";
            this.BTN_FILE_OPEN.Click += new System.EventHandler(this.BTN_FILE_OPEN_Click);
            // 
            // TBAR_SEP0
            // 
            this.TBAR_SEP0.Name = "TBAR_SEP0";
            this.TBAR_SEP0.Size = new System.Drawing.Size(6, 31);
            // 
            // BTN_FILE_EXTRACT
            // 
            this.BTN_FILE_EXTRACT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BTN_FILE_EXTRACT.Enabled = false;
            this.BTN_FILE_EXTRACT.Image = ((System.Drawing.Image)(resources.GetObject("BTN_FILE_EXTRACT.Image")));
            this.BTN_FILE_EXTRACT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_FILE_EXTRACT.Name = "BTN_FILE_EXTRACT";
            this.BTN_FILE_EXTRACT.Size = new System.Drawing.Size(28, 28);
            this.BTN_FILE_EXTRACT.Text = "toolStripButton1";
            this.BTN_FILE_EXTRACT.ToolTipText = "Extract file... (CTRL+E)";
            this.BTN_FILE_EXTRACT.Click += new System.EventHandler(this.BTN_FILE_EXTRACT_Click);
            // 
            // TBAR_SEP1
            // 
            this.TBAR_SEP1.Name = "TBAR_SEP1";
            this.TBAR_SEP1.Size = new System.Drawing.Size(6, 31);
            // 
            // BTN_FILE_REBUILD
            // 
            this.BTN_FILE_REBUILD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BTN_FILE_REBUILD.Image = ((System.Drawing.Image)(resources.GetObject("BTN_FILE_REBUILD.Image")));
            this.BTN_FILE_REBUILD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_FILE_REBUILD.Name = "BTN_FILE_REBUILD";
            this.BTN_FILE_REBUILD.Size = new System.Drawing.Size(28, 28);
            this.BTN_FILE_REBUILD.Text = "toolStripButton1";
            this.BTN_FILE_REBUILD.ToolTipText = "Rebuild file... (CTRL+R)";
            this.BTN_FILE_REBUILD.Click += new System.EventHandler(this.BTN_FILE_REBUILD_Click);
            // 
            // TBAR_SEP2
            // 
            this.TBAR_SEP2.ForeColor = System.Drawing.SystemColors.Control;
            this.TBAR_SEP2.Name = "TBAR_SEP2";
            this.TBAR_SEP2.Size = new System.Drawing.Size(124, 28);
            this.TBAR_SEP2.Text = "                                       ";
            // 
            // BTN_WIP_FOLDER
            // 
            this.BTN_WIP_FOLDER.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BTN_WIP_FOLDER.Image = ((System.Drawing.Image)(resources.GetObject("BTN_WIP_FOLDER.Image")));
            this.BTN_WIP_FOLDER.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_WIP_FOLDER.Name = "BTN_WIP_FOLDER";
            this.BTN_WIP_FOLDER.Size = new System.Drawing.Size(28, 28);
            this.BTN_WIP_FOLDER.Text = "toolStripButton1";
            this.BTN_WIP_FOLDER.ToolTipText = "Open WIP RDT folder (F2)";
            this.BTN_WIP_FOLDER.Click += new System.EventHandler(this.BTN_WIP_FOLDER_Click);
            // 
            // TBAR_SEP3
            // 
            this.TBAR_SEP3.AutoSize = false;
            this.TBAR_SEP3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBAR_SEP3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBAR_SEP3.Name = "TBAR_SEP3";
            this.TBAR_SEP3.Size = new System.Drawing.Size(8, 28);
            this.TBAR_SEP3.Text = "      ";
            // 
            // BTN_CLEAR_LOG
            // 
            this.BTN_CLEAR_LOG.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BTN_CLEAR_LOG.Image = ((System.Drawing.Image)(resources.GetObject("BTN_CLEAR_LOG.Image")));
            this.BTN_CLEAR_LOG.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_CLEAR_LOG.Name = "BTN_CLEAR_LOG";
            this.BTN_CLEAR_LOG.Size = new System.Drawing.Size(28, 28);
            this.BTN_CLEAR_LOG.Text = "toolStripButton1";
            this.BTN_CLEAR_LOG.ToolTipText = "Clear the log (F5)";
            this.BTN_CLEAR_LOG.Click += new System.EventHandler(this.BTN_CLEAR_LOG_Click);
            // 
            // DLG_FILE_OPEN
            // 
            this.DLG_FILE_OPEN.Filter = "RDT files|*.RDT";
            // 
            // DLG_FOLDER
            // 
            this.DLG_FOLDER.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.DLG_FOLDER.ShowNewFolderButton = false;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 689);
            this.Controls.Add(this.BAR_TOOL);
            this.Controls.Add(this.LST_LOG);
            this.Controls.Add(this.LST_TOC);
            this.Controls.Add(this.BAR_STAT);
            this.Controls.Add(this.MNU_MAIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MNU_MAIN;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 727);
            this.MinimumSize = new System.Drawing.Size(900, 727);
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "netbioRDTx";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.BAR_STAT.ResumeLayout(false);
            this.BAR_STAT.PerformLayout();
            this.MNU_MAIN.ResumeLayout(false);
            this.MNU_MAIN.PerformLayout();
            this.BAR_TOOL.ResumeLayout(false);
            this.BAR_TOOL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip BAR_STAT;
        private System.Windows.Forms.MenuStrip MNU_MAIN;
        private System.Windows.Forms.ToolStripMenuItem M_FILE;
        private System.Windows.Forms.ToolStripMenuItem M_FILE_OPEN;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem M_FILE_EXTRACT;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem M_FILE_REBUILD;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem M_FILE_EXIT;
        private System.Windows.Forms.ListView LST_TOC;
        private System.Windows.Forms.ListBox LST_LOG;
        private System.Windows.Forms.ToolStrip BAR_TOOL;
        private System.Windows.Forms.ColumnHeader CLM_IDX;
        private System.Windows.Forms.ColumnHeader CLM_OFFSET;
        private System.Windows.Forms.ColumnHeader CLM_SIZE;
        private System.Windows.Forms.ColumnHeader CLM_TYPE;
        private System.Windows.Forms.ToolStripStatusLabel LBL_PROGRESS;
        private System.Windows.Forms.ToolStripStatusLabel LBL_RDT_SIZE;
        private System.Windows.Forms.ToolStripStatusLabel LBL_RDT_NAME;
        private System.Windows.Forms.ToolStripButton BTN_FILE_OPEN;
        private System.Windows.Forms.ToolStripSeparator TBAR_SEP0;
        private System.Windows.Forms.ToolStripButton BTN_FILE_EXTRACT;
        private System.Windows.Forms.ToolStripSeparator TBAR_SEP1;
        private System.Windows.Forms.ToolStripButton BTN_FILE_REBUILD;
        private System.Windows.Forms.OpenFileDialog DLG_FILE_OPEN;
        private System.Windows.Forms.FolderBrowserDialog DLG_FOLDER;
        private System.Windows.Forms.ToolStripButton BTN_WIP_FOLDER;
        private System.Windows.Forms.ToolStripMenuItem M_HELP;
        private System.Windows.Forms.ToolStripMenuItem M_HELP_ABOUT;
        private System.Windows.Forms.ToolStripLabel TBAR_SEP2;
        private System.Windows.Forms.ToolStripLabel TBAR_SEP3;
        private System.Windows.Forms.ToolStripButton BTN_CLEAR_LOG;
        private System.Windows.Forms.ToolStripMenuItem M_TOOLS;
        private System.Windows.Forms.ToolStripMenuItem M_TOOLS_CLEAR_LOG;
        private System.Windows.Forms.ToolStripMenuItem M_FILE_SHOW_WIP;
    }
}

