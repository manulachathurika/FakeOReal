namespace FakeOReal.Encryption
{
    partial class VisibleWatermark
    {
       
        // Required designer variable.
        
        private System.ComponentModel.IContainer components = null;

      
        // Clean up any resources being used.
        
        // true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // Required method for Designer support - do not modify
        // the contents of this method with the code editor.
      
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisibleWatermark));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbxApplyWatermark = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.gbxPosition = new System.Windows.Forms.GroupBox();
            this.optBottom = new System.Windows.Forms.RadioButton();
            this.optTop = new System.Windows.Forms.RadioButton();
            this.gbxWatermarkText = new System.Windows.Forms.GroupBox();
            this.btnFont = new System.Windows.Forms.Button();
            this.cboOpacity = new System.Windows.Forms.ComboBox();
            this.lblOpacity = new System.Windows.Forms.Label();
            this.lblWmark = new System.Windows.Forms.Label();
            this.txtWaterMark = new System.Windows.Forms.TextBox();
            this.picContainer = new System.Windows.Forms.PictureBox();
            
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbxApplyWatermark.SuspendLayout();
            this.gbxPosition.SuspendLayout();
            this.gbxWatermarkText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbxApplyWatermark);
            this.splitContainer1.Panel1.Controls.Add(this.gbxPosition);
            this.splitContainer1.Panel1.Controls.Add(this.gbxWatermarkText);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel2.Controls.Add(this.picContainer);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(761, 522);
            this.splitContainer1.SplitterDistance = 107;
            this.splitContainer1.TabIndex = 2;
            // 
            // gbxApplyWatermark
            // 
            this.gbxApplyWatermark.Controls.Add(this.btnSave);
            this.gbxApplyWatermark.Controls.Add(this.btnPreview);
            this.gbxApplyWatermark.Location = new System.Drawing.Point(627, 7);
            this.gbxApplyWatermark.Name = "gbxApplyWatermark";
            this.gbxApplyWatermark.Size = new System.Drawing.Size(114, 89);
            this.gbxApplyWatermark.TabIndex = 2;
            this.gbxApplyWatermark.TabStop = false;
            this.gbxApplyWatermark.Text = "Apply Watermark";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(7, 59);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save As...";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(6, 29);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(102, 23);
            this.btnPreview.TabIndex = 0;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // gbxPosition
            // 
            this.gbxPosition.Controls.Add(this.optBottom);
            this.gbxPosition.Controls.Add(this.optTop);
            this.gbxPosition.Location = new System.Drawing.Point(503, 7);
            this.gbxPosition.Name = "gbxPosition";
            this.gbxPosition.Size = new System.Drawing.Size(118, 89);
            this.gbxPosition.TabIndex = 1;
            this.gbxPosition.TabStop = false;
            this.gbxPosition.Text = "Watermark Position";
            // 
            // optBottom
            // 
            this.optBottom.AutoSize = true;
            this.optBottom.Location = new System.Drawing.Point(29, 56);
            this.optBottom.Name = "optBottom";
            this.optBottom.Size = new System.Drawing.Size(58, 17);
            this.optBottom.TabIndex = 1;
            this.optBottom.TabStop = true;
            this.optBottom.Text = "Bottom";
            this.optBottom.UseVisualStyleBackColor = true;
            // 
            // optTop
            // 
            this.optTop.AutoSize = true;
            this.optTop.Location = new System.Drawing.Point(29, 33);
            this.optTop.Name = "optTop";
            this.optTop.Size = new System.Drawing.Size(44, 17);
            this.optTop.TabIndex = 0;
            this.optTop.TabStop = true;
            this.optTop.Text = "Top";
            this.optTop.UseVisualStyleBackColor = true;
            // 
            // gbxWatermarkText
            // 
            this.gbxWatermarkText.Controls.Add(this.btnFont);
            this.gbxWatermarkText.Controls.Add(this.cboOpacity);
            this.gbxWatermarkText.Controls.Add(this.lblOpacity);
            this.gbxWatermarkText.Controls.Add(this.lblWmark);
            this.gbxWatermarkText.Controls.Add(this.txtWaterMark);
            this.gbxWatermarkText.Location = new System.Drawing.Point(5, 5);
            this.gbxWatermarkText.Name = "gbxWatermarkText";
            this.gbxWatermarkText.Size = new System.Drawing.Size(492, 91);
            this.gbxWatermarkText.TabIndex = 0;
            this.gbxWatermarkText.TabStop = false;
            this.gbxWatermarkText.Text = "Watermark Text";
            this.gbxWatermarkText.Enter += new System.EventHandler(this.gbxWatermarkText_Enter);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(370, 50);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(116, 23);
            this.btnFont.TabIndex = 4;
            this.btnFont.Text = "Set Font...";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // cboOpacity
            // 
            this.cboOpacity.FormattingEnabled = true;
            this.cboOpacity.Items.AddRange(new object[] {
            "100%",
            "75%",
            "50%",
            "25%",
            "10%"});
            this.cboOpacity.Location = new System.Drawing.Point(365, 20);
            this.cboOpacity.Name = "cboOpacity";
            this.cboOpacity.Size = new System.Drawing.Size(121, 21);
            this.cboOpacity.TabIndex = 3;
            // 
            // lblOpacity
            // 
            this.lblOpacity.AutoSize = true;
            this.lblOpacity.Location = new System.Drawing.Point(320, 24);
            this.lblOpacity.Name = "lblOpacity";
            this.lblOpacity.Size = new System.Drawing.Size(43, 13);
            this.lblOpacity.TabIndex = 2;
            this.lblOpacity.Text = "Opacity";
            // 
            // lblWmark
            // 
            this.lblWmark.AutoSize = true;
            this.lblWmark.Location = new System.Drawing.Point(8, 22);
            this.lblWmark.Name = "lblWmark";
            this.lblWmark.Size = new System.Drawing.Size(28, 13);
            this.lblWmark.TabIndex = 1;
            this.lblWmark.Text = "Text";
            // 
            // txtWaterMark
            // 
            this.txtWaterMark.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWaterMark.Location = new System.Drawing.Point(38, 19);
            this.txtWaterMark.Name = "txtWaterMark";
            this.txtWaterMark.Size = new System.Drawing.Size(253, 22);
            this.txtWaterMark.TabIndex = 0;
            // 
            // picContainer
            // 
            this.picContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picContainer.Location = new System.Drawing.Point(0, 0);
            this.picContainer.Name = "picContainer";
            this.picContainer.Size = new System.Drawing.Size(761, 411);
            this.picContainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picContainer.TabIndex = 0;
            this.picContainer.TabStop = false;
            this.picContainer.Click += new System.EventHandler(this.picContainer_Click);
            // 
            // VisibleWatermark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 522);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VisibleWatermark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visible Watermark";
            this.Load += new System.EventHandler(this.frmWatermark_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.gbxApplyWatermark.ResumeLayout(false);
            this.gbxPosition.ResumeLayout(false);
            this.gbxPosition.PerformLayout();
            this.gbxWatermarkText.ResumeLayout(false);
            this.gbxWatermarkText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContainer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;     
        private System.Windows.Forms.SaveFileDialog SaveFileDialog1;
        private System.Windows.Forms.PictureBox picContainer;
        private System.Windows.Forms.GroupBox gbxWatermarkText;
        private System.Windows.Forms.ComboBox cboOpacity;
        private System.Windows.Forms.Label lblOpacity;
        private System.Windows.Forms.Label lblWmark;
        private System.Windows.Forms.TextBox txtWaterMark;
        private System.Windows.Forms.GroupBox gbxPosition;
        private System.Windows.Forms.GroupBox gbxApplyWatermark;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.RadioButton optBottom;
        private System.Windows.Forms.RadioButton optTop;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnSave;

    }
}