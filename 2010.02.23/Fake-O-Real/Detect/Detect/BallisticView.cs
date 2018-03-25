using System;
using System.Windows.Forms;
using Microsoft.Practices.CompositeUI.SmartParts;
using Microsoft.Practices.ObjectBuilder;
using FakeOReal.Infrastructure.Interface;
using System.Drawing;
using System.Security.Cryptography;
using Microsoft.Practices.CompositeUI.EventBroker;
using FakeOReal.Detect.Constants;

namespace FakeOReal.Detect
{
    public partial class BallisticView : UserControl, IBallisticView
    {
        public static Image image;        
        private static Image image1;
        private static Image image2;
        private static bool im = false;
        public BallisticView()
        {           
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            _presenter.OnViewReady();
            base.OnLoad(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Title = "Choose an Image";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filename = ofd.FileName;
                try
                {
                    im = true;
                    image1 = Image.FromFile(filename);
                    this.pictureBox1.Image = image1;
                    int s = filename.LastIndexOf('\\');
                    this.imageLabel1.Text = filename.Substring(filename.LastIndexOf('\\') + 1, ((filename.Length - 1) - filename.LastIndexOf('\\')));
                }
                catch
                {
                    MessageBox.Show(String.Format("Invalide File: {0}", ofd.FileName));
                    return;
                }
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(image==null)
            {
                MessageBox.Show("Null image");
            }
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Title = "Choose an Image";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filename = ofd.FileName;
                try
                {
                    image2 = Image.FromFile(filename);                    
                    this.pictureBox2.Image = image2;
                    int s = filename.LastIndexOf('\\');
                    this.imageLabel2.Text = filename.Substring(filename.LastIndexOf('\\') + 1, ((filename.Length - 1) - filename.LastIndexOf('\\')));                    
                }
                catch
                {
                    MessageBox.Show(String.Format("Invalide File: {0}", ofd.FileName));
                    return;
                }
            }  
        }

        private void test_Click(object sender, EventArgs e)
        {           
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();           
            byte[] lumi1;            
            byte[] chro1;
            if(im){
               lumi1 = image1.GetPropertyItem(0x5090).Value;
               chro1  = image1.GetPropertyItem(0x5091).Value;
            }else{
                lumi1 = image.GetPropertyItem(0x5090).Value;
                chro1 = image.GetPropertyItem(0x5091).Value;
            }
            byte[] data1 = new byte[256];
            byte[] lumi2 = image2.GetPropertyItem(0x5090).Value;
            byte[] chro2 = image2.GetPropertyItem(0x5091).Value;
            byte[] data2 = new byte[256];
            Array.Copy(lumi1, 0, data1, 0, 128);
            Array.Copy(chro1, 0, data1, 128, 128);
            Array.Copy(lumi2, 0, data2, 0, 128);
            Array.Copy(chro2, 0, data2, 128, 128);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] hash1 = md5.ComputeHash(data1);
            byte[] hash2 = md5.ComputeHash(data2);
            string hashedValue1 = "";
            foreach (byte b in hash1)
            {
                hashedValue1 += b.ToString("x2");
            }
            string hashedValue2 = "";
            foreach (byte b in hash2)
            {
                hashedValue2 += b.ToString("x2");
            }
            if (hashedValue1.Equals(hashedValue2))
            {
                this.result.Text = "Both Images are from the same source.";
            }
            else {
                this.result.Text = "Both Images are from different sources.";
            }
        }        
    }
}