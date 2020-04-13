using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NReco.VideoConverter;
using System.Windows.Forms;
using System.IO;
namespace Bcompression
{
   sealed class VideoConversion
    {
        String str1,str;
     
        SaveFileDialog sfd = new SaveFileDialog();
     public void get1(String str) {
         this.str = str;
         mp4();
        
       }
     public void get2(String str)
     {
         this.str = str;
         wmv();

     }
     public void get3(String str)
     {
         this.str = str;
         gif();

     }
  
     public void get4(String str)
     {
         this.str = str;
         mpeg();

     }
     public void get5(String str)
     {
         this.str = str;
         webm();

     }
  private   void mp4() {
         var convert = new FFMpegConverter();
         sfd.ShowDialog();
         str1 = sfd.FileName;
         str1 += ".mp4";
         convert.ConvertMedia(str, str1, Format.mp4);
         MessageBox.Show("Successfully converted in mp4");
     
     }
  private void wmv()
     {
         var convert = new FFMpegConverter();
         sfd.ShowDialog();
         str1 = sfd.FileName;
         str1 += ".wmv";
         convert.ConvertMedia(str, str1, Format.mp4);
         MessageBox.Show("Successfully converted in wmv");

     }
  private void gif()
     {
         var convert = new FFMpegConverter();
         sfd.ShowDialog();
         str1 = sfd.FileName;
         str1 += ".gif";
         convert.ConvertMedia(str, str1, Format.gif);
         MessageBox.Show("Successfully converted in gif");

     }
  private void mpeg()
     {
         var convert = new FFMpegConverter();
         sfd.ShowDialog();
         str1 = sfd.FileName;
         str1 += ".mpeg";
         convert.ConvertMedia(str, str1, Format.mpeg);
         MessageBox.Show("Successfully converted in mpeg");

     }
  private void webm()
  {

           var convert = new FFMpegConverter();
           sfd.ShowDialog();
           str1 = sfd.FileName;
           str1 += ".webm";
           convert.ConvertMedia(str, str1, Format.webm);
           MessageBox.Show("Successfully converted in webm");

       
       }
    }
}
