using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FakeOReal.ImageAnalysis
{
    public partial class GetParam : Form
    {
        ModuleController mc;
        public GetParam(ModuleController mc)
        {
            this.mc = mc;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.mc.doCanny(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }
    }
}
