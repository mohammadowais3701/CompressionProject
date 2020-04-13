using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bcompression
{
 sealed class Decompress
    {
        public void get(String str) {
            dodecompress(str);
        
        }
        private void dodecompress(String str) {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            String str1 = sfd.FileName;
            str1 += ".txt";
        
      List<Int32> lettersExtract = new List<Int32>(); 

  Bitmap bmp = new Bitmap(Bitmap.FromFile(str)); 

 

    for (int row = 1; row < bmp.Width; row++) 

    {

        for (int column = 1; column <bmp.Height; column++) 
        {

           var cr = bmp.GetPixel(row, column); 
 

            lettersExtract.Add(cr.R); 

 

            lettersExtract.Add(cr.G);

 

            lettersExtract.Add(cr.B); 

        }

    }


 

using (System.IO.StreamWriter file = new System.IO.StreamWriter(str1)) 

{

       foreach (int write in lettersExtract)

       {

            if (write == 255) 

                     file.WriteLine("");

            else

                file.Write((Char)write); 

       }

    }
MessageBox.Show("Decompressed");
        
        }
    }
}
