using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FakeOReal.Infrastructure.Interface
{
    public class OnImageLoad:EventArgs
    {
        private Image image;
        private string path;
        public Image img { get { return image; } }
        public string file { get { return path; } }
        public OnImageLoad(Image img, string filepath) { image = img; path = filepath; } 
    }
}
