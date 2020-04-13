using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bcompression
{
  sealed  class Compress_img
    {  
        public  Compress_img()
        {

        }
        public  Bitmap print(string s)
        {
            
            Bitmap bmp = new Bitmap(s);
            int width = bmp.Width;
            int height = bmp.Height;
            Color p;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    p = bmp.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R - 40;
                    int g = p.G - 40;
                    int b = p.B - 40;

                    while (r < 0)
                        r++;
                    while (g < 0)
                        g++;
                    while (b < 0)
                        b++;

                    bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            return bmp;
        }

    }
}
