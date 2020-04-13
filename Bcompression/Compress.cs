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
 sealed class Compress:FileCompression
    {
     private Button button4;
 
        public void get(String str) {
            docompress(str);
        
        }
      private void docompress(String str){
   
        String str2;
        str2 = str + ".png";
        using (StreamReader sr = File.OpenText(str)) 
          {
          
           var line = "";

              Int32 R = 0;

              Int32 G = 0; 
              Int32 B = 0; 

        List<Int32> letters = new List<Int32>(); 


              while ((line = sr.ReadLine()) != null) 
              {

                  foreach (char ch in line) 
                  {

                      letters.Add(Convert.ToInt32(ch)); 

                  }

                  letters.Add(255); 

              }

              Int32 square =(Int32)( Math.Sqrt(letters.Count / 3)); 

            square += 1; 



              Bitmap bmp = new Bitmap((Int32)square + 2, (Int32)square + 2); 



              var count = 0; 

              for (int row = 1; row <= square; row++) 
              {

                  for (int column = 1; column <= square; column++) 
                  {

                      if (count < (letters.Count - 3)) 
                      {
                         
                          R = letters[count++]; 

                          G = letters[count++]; 

                          B = letters[count++]; 

                          bmp.SetPixel(row, column, (Color.FromArgb(255, R, G, B)));
                      }

                  }

              }

              bmp.Save(str2,System.Drawing.Imaging.ImageFormat.Png); 
              MessageBox.Show("Compressed");
          }
      
      }

      private void InitializeComponent()
      {
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(394, 95);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Video Conversion";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Compress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(773, 376);
            this.Controls.Add(this.button4);
            this.Name = "Compress";
            this.Controls.SetChildIndex(this.button4, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      private void button4_Click(object sender, EventArgs e)
      {

      }
    }
}
