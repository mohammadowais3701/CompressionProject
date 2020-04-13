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
using System.IO.Compression;

namespace Bcompression
{
  sealed  public partial class FolderCompression : Form
    {
        Archiving Arr = new Archiving();
        public FolderCompression()
        {
            InitializeComponent();
        }
     
        private void compressbtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            string path = string.Empty;
            if (fbd.ShowDialog()==DialogResult.OK)
            {
                path = fbd.SelectedPath;
            }
            if (path != string.Empty)
            {


                DirectoryInfo Dinfo = new DirectoryInfo(path);
                foreach (FileInfo finfo in Dinfo.GetFiles())
                {
                    if (yesdo)
                    {
                        Arr.Compressfolder(finfo,this.listBox1);
                        // File.Delete(finfo.FullName); 

                    }
                    else
                    {
                        Arr.Compressfolder(finfo,this.listBox1);

                    }
                } if (yesdo)
                    foreach (FileInfo sFile in Dinfo.GetFiles())
                    {
                        if (sFile.Extension != ".gz")
                            System.IO.File.Delete(sFile.FullName);
                    }
            }
            else {
                MessageBox.Show("Select Folder");
            
            }
        }
        bool yesdo = false;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                yesdo = true;
                return;
            }
            yesdo = false;

        }

        private void Extractbtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            string path = string.Empty;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                path = fbd.SelectedPath;
            }
            DirectoryInfo Dinfo = new DirectoryInfo(path);
            foreach (FileInfo finfo in Dinfo.GetFiles())
            {
               
                    Arr.Extract(finfo);
                    File.Delete(finfo.FullName);
                 //   Arr.Extract(finfo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileCompression FC = new FileCompression();
            this.Hide();
            FC.Show();
        }
    }
}
