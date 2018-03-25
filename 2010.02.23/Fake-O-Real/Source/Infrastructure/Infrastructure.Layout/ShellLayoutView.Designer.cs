namespace FakeOReal.Infrastructure.Layout
{
    partial class ShellLayoutView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_presenter != null)
                    _presenter.Dispose();

                if (components != null)
                    components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShellLayoutView));
            this._mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this._fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._opentoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this._mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._tabWorkspace = new Microsoft.Practices.CompositeUI.WinForms.TabWorkspace();
            this.imageTab = new System.Windows.Forms.TabPage();
            this.panAndZoomPictureBox1 = new Emgu.CV.UI.PanAndZoomPictureBox();
            this._rightWorkspace = new Microsoft.Practices.CompositeUI.WinForms.DeckWorkspace();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._mainMenuStrip.SuspendLayout();
            this._mainStatusStrip.SuspendLayout();
            this._mainToolStrip.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this._tabWorkspace.SuspendLayout();
            this.imageTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panAndZoomPictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainMenuStrip
            // 
            this._mainMenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this._mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileToolStripMenuItem});
            this._mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this._mainMenuStrip.Name = "_mainMenuStrip";
            this._mainMenuStrip.Size = new System.Drawing.Size(613, 24);
            this._mainMenuStrip.TabIndex = 4;
            this._mainMenuStrip.Text = "_mainMenuStrip";
            // 
            // _fileToolStripMenuItem
            // 
            this._fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this._fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._opentoolStripMenuItem,
            this.databaseSetupToolStripMenuItem,
            this._exitToolStripMenuItem});
            this._fileToolStripMenuItem.Name = "_fileToolStripMenuItem";
            this._fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this._fileToolStripMenuItem.Text = "&File";
            // 
            // _opentoolStripMenuItem
            // 
            this._opentoolStripMenuItem.Name = "_opentoolStripMenuItem";
            this._opentoolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
            this._opentoolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this._opentoolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this._opentoolStripMenuItem.Text = "Open";
            this._opentoolStripMenuItem.Click += new System.EventHandler(this._opentoolStripMenuItem_Click);
            // 
            // databaseSetupToolStripMenuItem
            // 
            this.databaseSetupToolStripMenuItem.Name = "databaseSetupToolStripMenuItem";
            this.databaseSetupToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.databaseSetupToolStripMenuItem.Text = "Database Setup";
            this.databaseSetupToolStripMenuItem.Click += new System.EventHandler(this.databaseSetupToolStripMenuItem_Click);
            // 
            // _exitToolStripMenuItem
            // 
            this._exitToolStripMenuItem.Name = "_exitToolStripMenuItem";
            this._exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this._exitToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this._exitToolStripMenuItem.Text = "E&xit";
            this._exitToolStripMenuItem.Click += new System.EventHandler(this.OnFileExit);
            // 
            // _statusLabel
            // 
            this._statusLabel.Name = "_statusLabel";
            this._statusLabel.Size = new System.Drawing.Size(38, 17);
            this._statusLabel.Text = "Ready";
            // 
            // _mainStatusStrip
            // 
            this._mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._statusLabel});
            this._mainStatusStrip.Location = new System.Drawing.Point(0, 462);
            this._mainStatusStrip.Name = "_mainStatusStrip";
            this._mainStatusStrip.Size = new System.Drawing.Size(613, 22);
            this._mainStatusStrip.TabIndex = 6;
            this._mainStatusStrip.Text = "_mainStatusStrip";
            // 
            // _mainToolStrip
            // 
            this._mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1});
            this._mainToolStrip.Location = new System.Drawing.Point(0, 24);
            this._mainToolStrip.Name = "_mainToolStrip";
            this._mainToolStrip.Size = new System.Drawing.Size(613, 25);
            this._mainToolStrip.TabIndex = 5;
            this._mainToolStrip.Text = "_mainToolStrip";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Open Image";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._tabWorkspace);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._rightWorkspace);
            this.splitContainer1.Size = new System.Drawing.Size(613, 413);
            this.splitContainer1.SplitterDistance = 497;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 7;
            // 
            // _tabWorkspace
            // 
            this._tabWorkspace.Controls.Add(this.imageTab);
            this._tabWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tabWorkspace.HotTrack = true;
            this._tabWorkspace.ImeMode = System.Windows.Forms.ImeMode.Off;
            this._tabWorkspace.Location = new System.Drawing.Point(0, 0);
            this._tabWorkspace.Multiline = true;
            this._tabWorkspace.Name = "_tabWorkspace";
            this._tabWorkspace.SelectedIndex = 0;
            this._tabWorkspace.Size = new System.Drawing.Size(497, 413);
            this._tabWorkspace.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this._tabWorkspace.TabIndex = 0;
            // 
            // imageTab
            // 
            this.imageTab.Controls.Add(this.panAndZoomPictureBox1);
            this.imageTab.Location = new System.Drawing.Point(4, 22);
            this.imageTab.Name = "imageTab";
            this.imageTab.Padding = new System.Windows.Forms.Padding(3);
            this.imageTab.Size = new System.Drawing.Size(489, 387);
            this.imageTab.TabIndex = 0;
            this.imageTab.UseVisualStyleBackColor = true;
            // 
            // panAndZoomPictureBox1
            // 
            this.panAndZoomPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panAndZoomPictureBox1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.panAndZoomPictureBox1.Location = new System.Drawing.Point(3, 3);
            this.panAndZoomPictureBox1.Name = "panAndZoomPictureBox1";
            this.panAndZoomPictureBox1.Size = new System.Drawing.Size(483, 381);
            this.panAndZoomPictureBox1.TabIndex = 0;
            this.panAndZoomPictureBox1.TabStop = false;
            // 
            // _rightWorkspace
            // 
            this._rightWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rightWorkspace.Location = new System.Drawing.Point(0, 0);
            this._rightWorkspace.Name = "_rightWorkspace";
            this._rightWorkspace.Size = new System.Drawing.Size(115, 413);
            this._rightWorkspace.TabIndex = 1;
            this._rightWorkspace.Text = "_rightWorkspace";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 26);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.closeToolStripMenuItem.Text = "Close Tab";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // ShellLayoutView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this._mainStatusStrip);
            this.Controls.Add(this._mainToolStrip);
            this.Controls.Add(this._mainMenuStrip);
            this.Name = "ShellLayoutView";
            this.Size = new System.Drawing.Size(613, 484);
            this._mainMenuStrip.ResumeLayout(false);
            this._mainMenuStrip.PerformLayout();
            this._mainStatusStrip.ResumeLayout(false);
            this._mainStatusStrip.PerformLayout();
            this._mainToolStrip.ResumeLayout(false);
            this._mainToolStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this._tabWorkspace.ResumeLayout(false);
            this.imageTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panAndZoomPictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem _fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel _statusLabel;
        private System.Windows.Forms.StatusStrip _mainStatusStrip;
        private System.Windows.Forms.ToolStrip _mainToolStrip;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Microsoft.Practices.CompositeUI.WinForms.DeckWorkspace _rightWorkspace;
        private Microsoft.Practices.CompositeUI.WinForms.TabWorkspace _tabWorkspace;
        private System.Windows.Forms.ToolStripMenuItem _opentoolStripMenuItem;
        private System.Windows.Forms.TabPage imageTab;
        private Emgu.CV.UI.PanAndZoomPictureBox panAndZoomPictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem databaseSetupToolStripMenuItem;
    }
}

