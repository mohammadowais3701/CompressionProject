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
  sealed  public partial class Video : Form
    {
        public Video()
        {
            InitializeComponent();
        }

        private void videotextbox_TextChanged(object sender, EventArgs e)
        {
          //  openFileDialog2.ShowDialog();
         
        }

        private void mp4_Click(object sender, EventArgs e)
        {
            videotextbox.Text = openFileDialog2.FileName;
            String str = videotextbox.Text;
            if (str != "")
                new VideoConversion().get1(str);
            else
            {
                MessageBox.Show("Select your file");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            videotextbox.Text = openFileDialog2.FileName;
            String str = videotextbox.Text;
        }

        private void wmv_Click(object sender, EventArgs e)
        {
            videotextbox.Text = openFileDialog2.FileName;
            String str = videotextbox.Text;
            if (str != "")
                new VideoConversion().get2(str);
            else
            {
                MessageBox.Show("Select your file");
            }
        }

        private void Gif_Click(object sender, EventArgs e)
        {
            videotextbox.Text = openFileDialog2.FileName;
            String str = videotextbox.Text;
            if (str != "")
                new VideoConversion().get3(str);
            else
            {
                MessageBox.Show("Select your file");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            videotextbox.Text = openFileDialog2.FileName;
            String str = videotextbox.Text;
            if (str != "")
                new VideoConversion().get4(str);
            else
            {
                MessageBox.Show("Select your file");
            }
        }

        private void webm_Click(object sender, EventArgs e)
        {
            videotextbox.Text = openFileDialog2.FileName;
            String str = videotextbox.Text;
            if (str != "")
                new VideoConversion().get5(str);
            else
            {
                MessageBox.Show("Select your file");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileCompression FC = new FileCompression();
            this.Hide();
            FC.Show();
        }
    }
}
