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
    public partial class GetParam3 : Form
    {
        ModuleController mc;
        public GetParam3(ModuleController mc)
        {
            this.mc = mc;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.mc.doGaussian(trackBar1.Value,trackBar2.Value);
        }
    }
}
