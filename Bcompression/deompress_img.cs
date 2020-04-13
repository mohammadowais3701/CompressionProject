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
  sealed  class deompress_img
    {
          public  deompress_img()
        {

        }
        public Bitmap decomp(string s)
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
                    int r = p.R + 40;
                    int g = p.G + 40;
                    int b = p.B + 40;

                    while (r > 255)
                        r--;
                    while (g > 255)
                        g--;
                    while (b > 255)
                        b--;

                    bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            return bmp;

        }


    }
}
