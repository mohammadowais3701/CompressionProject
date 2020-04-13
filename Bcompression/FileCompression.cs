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
  public partial class FileCompression : Form
    {
        public FileCompression()
        {
            InitializeComponent();
            
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
        openFileDialog1.ShowDialog();
       filetextbox.Text = openFileDialog1.FileName;
        String str = filetextbox.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            filetextbox.Text = openFileDialog1.FileName;
            String str = filetextbox.Text;
            if (str != "")
                new Compress().get(str);
            else {
                MessageBox.Show("Select your file");
            }

        }

        private void decompress_btn_Click(object sender, EventArgs e)
        {

            filetextbox.Text = openFileDialog1.FileName;
            String str = filetextbox.Text;
      
            if (str != "")
                new Decompress().get(str);
            else
            {
                MessageBox.Show("Select your file");
            }
        }

        private void filetextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderCompression fcom = new FolderCompression();
            this.Hide();
            fcom.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Video vd = new Video();
            this.Hide();
            vd.Show();
        }

        private void Imagebtn_Click(object sender, EventArgs e)
        {
            Imagecompress IC = new Imagecompress();
            this.Hide();
            IC.Show();
        }
    }
}
