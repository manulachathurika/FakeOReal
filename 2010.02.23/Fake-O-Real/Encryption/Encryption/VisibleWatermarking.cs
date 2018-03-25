using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO; //dibutuhkan untuk file info

namespace FakeOReal.Encryption
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class VisibleWatermarking : System.Windows.Forms.Form
    {
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;        
        private System.Windows.Forms.OpenFileDialog openWatermarkDialog;
        private Image coverImg;
        private Image watermarkImg;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Drawing.Bitmap watermarkBmp;
        private System.Drawing.Bitmap coverBmp;
       // private System.Drawing.Bitmap resultBmp = null;
        private string openCover;
        private string openWatermark;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Button button2;
        private Label label5;
        private Label label6;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label1;
        private Panel panel2;
        private Label label8;
        private ComboBox comboBox1;
        private ProgressBar progressBar1;        

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public VisibleWatermarking(string path)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 10;            
            coverImg = Image.FromFile(path);
            //coverImg = new Bitmap(coverImg);
            openCover = path;
            pictureBox1.Image = coverImg;
            label3.Text = Convert.ToString(coverImg.Width);
            label4.Text = Convert.ToString(coverImg.Height);     
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();            
            this.openWatermarkDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 248);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(616, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 21);
            this.button3.TabIndex = 6;
            this.button3.Text = "Add Watermark";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(759, 293);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 21);
            this.button4.TabIndex = 7;
            this.button4.Text = "Save Watermarked Image";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(616, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 248);
            this.panel3.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(8, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(281, 233);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(518, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Watermark";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(442, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 14;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(362, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 13;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(312, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Size :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(183, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 12;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(103, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 11;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(50, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Size :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(312, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 248);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(8, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(281, 233);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(319, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Opacity : ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0,1",
            "0,2",
            "0,3",
            "0,4",
            "0,5",
            "0,6",
            "0,7",
            "0,8",
            "0,9"});
            this.comboBox1.Location = new System.Drawing.Point(377, 293);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.Text = "0,1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(616, 264);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(291, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 20;
            // 
            // VisibleWatermarking
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(920, 321);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VisibleWatermarking";
            this.Text = "Visible Watermarking";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion           

        private void button2_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (openWatermarkDialog.ShowDialog() == DialogResult.OK)
                {
                    if (Image.FromFile(openWatermarkDialog.FileName).Width > 100 || Image.FromFile(openWatermarkDialog.FileName).Height > 100)
                    {
                        MessageBox.Show("Error,\n Watermark Cannot be Larger Than 100 x 100 pixel");
                    }
                    else
                    {
                        watermarkImg = Image.FromFile(openWatermarkDialog.FileName);
                        openWatermark = openWatermarkDialog.FileName;

                        pictureBox3.Width = Image.FromFile(openWatermarkDialog.FileName).Width;
                        pictureBox3.Height = Image.FromFile(openWatermarkDialog.FileName).Height;
                        pictureBox3.Image = Image.FromFile(openWatermarkDialog.FileName);
                        label6.Text = Convert.ToString(pictureBox3.Width);
                        label5.Text = Convert.ToString(pictureBox3.Height);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!\n" + ex.Message);
            }
        }

        private int pixelVal(int avemark, int pixcover, double opacity)
        {
            if (pixcover + (avemark * opacity) > 255)
            {
                return pixcover = 255;
            }
            else
            {
                return pixcover = Convert.ToInt32(pixcover + (avemark * opacity));
            }
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            try
            {
                progressBar1.Value = progressBar1.Value + 2;
                watermarkBmp = (Bitmap)Bitmap.FromFile(openWatermark);
                coverBmp = (Bitmap)Bitmap.FromFile(openCover);
                //resultBmp = null;
                int red = 0;
                int green = 0;
                int blue = 0;
                double opacity = Convert.ToDouble(comboBox1.Text);
                progressBar1.Value = progressBar1.Value + 2;

                if (watermarkBmp.Height > coverBmp.Height || watermarkBmp.Width > coverBmp.Width)
                {
                    pictureBox3.Image = null;
                    pictureBox2.Image = null;
                    MessageBox.Show("Over Sized Watermark, Please Use Smaller Watermark", "Error");
                }
                else
                {
                    progressBar1.Value = progressBar1.Value + 2;                   
                    try
                    {                        
                        for (int i = 0; i < watermarkBmp.Height; i++)
                        {
                            for (int j = 0; j < watermarkBmp.Width; j++)
                            {                                
                                red = pixelVal(watermarkBmp.GetPixel(i, j).R, coverBmp.GetPixel(i, j).R, opacity);
                                green = pixelVal(watermarkBmp.GetPixel(i, j).G, coverBmp.GetPixel(i, j).G, opacity);
                                blue = pixelVal(watermarkBmp.GetPixel(i, j).B, coverBmp.GetPixel(i, j).B, opacity);
                                coverBmp.SetPixel(i, j, Color.FromArgb(red, green, blue));
                            }
                        }                      
                        pictureBox2.Image = coverBmp;
                        progressBar1.Value = progressBar1.Value + 2;
                    }
                    catch (Exception ex)
                    {
                        pictureBox3.Image = null;
                        pictureBox2.Image = null;
                        MessageBox.Show(ex.Message, "Error");
                    }
                    progressBar1.Value = progressBar1.Value + 2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!\n" + ex.Message);
            }
        }

        private void button4_Click(object sender, System.EventArgs e)
        {         
            saveFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            try
            {
                if (DialogResult.OK == saveFileDialog.ShowDialog())
                {
                    if (saveFileDialog.FilterIndex == 1)
                    { pictureBox2.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp); }
                    else
                    {
                        if (saveFileDialog.FilterIndex == 2)
                        { pictureBox2.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg); }
                        else
                        { pictureBox2.Image.Save(saveFileDialog.FileName); }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!\n" + ex.Message);
            }
        }
    }
}