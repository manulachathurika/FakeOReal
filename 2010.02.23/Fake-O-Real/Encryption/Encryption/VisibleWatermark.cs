using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace FakeOReal.Encryption
{
    public partial class VisibleWatermark : Form
    {
        #region Member Variables

        string CurrentFile;       
        private string path;       
        System.Drawing.Color myWatermarkColor;
        System.Drawing.Font myFont;    
        
        #endregion

        #region Constructor


        // constructor with default configuration settings

        public VisibleWatermark(string filename)
        {
            InitializeComponent();
            // setup default settings
            myWatermarkColor = Color.SteelBlue;
            cboOpacity.SelectedIndex = 2;
            optTop.Checked = true;
            txtWaterMark.Text = "Your Name " +
                char.ConvertFromUtf32(169).ToString() + " " +
                DateTime.Now.Year.ToString() + ", All Rights Reserved";
            myFont = txtWaterMark.Font;
            path = filename;
            picContainer.Load(filename);
        }

        #endregion


        #region File IO
       // Save the Current Image with the Watermark
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // get the extension to figure out how to limit the save
                // option to the current image file type
                string strExt;

                CurrentFile = path;
                this.Text = "Fake-O-Real - Visible Watermark " + CurrentFile.ToString();

                strExt = System.IO.Path.GetExtension(CurrentFile);
                strExt = strExt.ToUpper();
                strExt = strExt.Remove(0, 0);

                // if the current image is, for example, a gif, only
                // allow the user to save the file with the watermark
                // as a gif
                SaveFileDialog1.Title = "Save File";
                SaveFileDialog1.DefaultExt = strExt;
                SaveFileDialog1.Filter = strExt + " Image Files|*." + strExt;
                SaveFileDialog1.FilterIndex = 0;
                

                if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (SaveFileDialog1.FileName == "")
                    {
                        return;
                    }
                    else
                    {
                        // save the file with the name supplied by the user                        
                        picContainer.Image.Save(SaveFileDialog1.FileName);
                    }

                    // update the current image file to point to the newly saved
                    // image
                    //CurrentFile = SaveFileDialog1.FileName;
                   // this.Text = "DIDS - Visible Watermark: " + CurrentFile;
                    MessageBox.Show(CurrentFile.ToString() + " saved.", "File Save");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Image Save Error");
            }
        }


        #endregion
        

        #region Watermarking
        
        // Display the watermark as it would appear after the
        // watermark were saved to the file

        private void btnPreview_Click(object sender, EventArgs e)
        {
            // Update the applicaton by reloading the image
                       
            picContainer.Load(path);
            int opac = 0;
            string sOpacity = cboOpacity.Text;

            // Determine the opacity of the watermark
            switch (sOpacity)
            {
                case "100%":
                    opac = 255; // 1 * 255
                    break;
                case "75%":
                    opac = 191; // .75 * 255
                    break;
                case "50%":
                    opac = 127; // .5 * 255
                    break;
                case "25%":
                    opac = 64;  // .25 * 255
                    break;
                case "10%":
                    opac = 25;  // .10 * 255
                    break;
                default:
                    opac = 127; // default at 50%; .5 * 255
                    break;
            }

            // Get a graphics context
            Graphics g = Graphics.FromImage(picContainer.Image);

            // Create a solid brush to write the watermark text on the image
            Brush myBrush = new SolidBrush(Color.FromArgb(opac, myWatermarkColor));

            // Calculate the size of the text
            SizeF sz = g.MeasureString(txtWaterMark.Text, myFont);

            // Creae a copy of variables to keep track of the
            // drawing position (X,Y)
            int X;
            int Y;

            // Set the drawing position based on the users
            // selection of placing the text at the bottom or
            // top of the image
            if (optTop.Checked == true)
            {
                X = (int)(picContainer.Image.Width - sz.Width) / 2;
                Y = (int)(picContainer.Top + sz.Height) / 2;
            }
            else
            {
                X = (int)(picContainer.Image.Width - sz.Width) / 2;
                Y = (int)(picContainer.Image.Height - sz.Height);
            }
            // draw the water mark text
            g.DrawString(txtWaterMark.Text, myFont, myBrush, new Point(X, Y));
        }
        
        // Set the font and color of the font for the watermark
        private void btnFont_Click(object sender, EventArgs e)
        {
            // default the current font and color to that
            // used in the watermark textbox
            fontDialog1.ShowColor = true;
            fontDialog1.Font = txtWaterMark.Font;
            fontDialog1.Color = txtWaterMark.ForeColor;
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                myFont = fontDialog1.Font;
                myWatermarkColor = fontDialog1.Color;
                txtWaterMark.Font = fontDialog1.Font;
                txtWaterMark.ForeColor = fontDialog1.Color;
            }
        }
        
        #endregion

        #region Dispose of the Application
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmWatermark_Load(object sender, EventArgs e)
        {

        }

        private void gbxWatermarkText_Enter(object sender, EventArgs e)
        {

        }

        private void picContainer_Click(object sender, EventArgs e)
        {

        }

        // Close the application

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #endregion   
            
            }
}