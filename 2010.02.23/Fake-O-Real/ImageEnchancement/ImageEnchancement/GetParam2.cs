using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FakeOReal.ImageEnchancement
{
    public partial class GetParam2 : Form
    {
        ModuleController mc;
        public GetParam2(ModuleController mc)
        {
            this.mc = mc;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (filter_name.Text.Equals("Conservative Filter"))
            {
                this.mc.doConservative(trackBar1.Value);
            }

            else if (filter_name.Text.Equals("Gamma Correction"))
            {
                this.mc.doGamma(trackBar1.Value);
            }
            else if (filter_name.Text.Equals("Brightness Correction"))
            {
                this.mc.doBrightness(trackBar1.Value);
            }
            else if (filter_name.Text.Equals("Contrast Correction"))
            {
                this.mc.doContrast(trackBar1.Value);
            }
        }
    }
}
