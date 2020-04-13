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
   sealed public partial class Imagecompress : Form
    {
        public Imagecompress()
        {
            InitializeComponent();
        }

        private void openbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "JPG Image(*.jpg)|*.jpg|BMP Image(*.bmp)|*.bmp|PNG Image(*.png)|.png";
            if (op.ShowDialog() == DialogResult.OK)
            {
               

                textBox1.Text = op.FileName;
                pictureBox1.Image = Image.FromFile(textBox1.Text);
            }
        }

        private void compressbtn_Click(object sender, EventArgs e)
        {
           
            //textBox1.Text = openFileDialog1.FileName;
            String str = textBox1.Text;

            if (str != "")
            {
                Compress_img c = new Compress_img();
                pictureBox2.Image = c.print(textBox1.Text);
                MessageBox.Show("Compressed!");
            }
            else
            {
                MessageBox.Show("Select your file");
            }
           
        }

        private void decompressbtn_Click(object sender, EventArgs e)
        {
          
            //textBox1.Text = openFileDialog1.FileName;
            String str = textBox1.Text;

            if (str != "")
            {
                deompress_img d = new deompress_img();
                pictureBox2.Image = d.decomp(textBox1.Text);
                MessageBox.Show("Decompressed!");
                

            }
            else
            {
                MessageBox.Show("Select your file");
            }
           
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            if (str != "")
            {
                SaveFileDialog sv = new SaveFileDialog();
                sv.Title = "Images";
                sv.Filter = "JPG Image(*.jpg)|*.jpg|BMP Image(*.bmp)|*.bmp|PNG Image(*.png)|.png";
                if (sv.ShowDialog() == DialogResult.OK)
                {
                    pictureBox2.Image.Save(sv.FileName);
                    MessageBox.Show("Saved!");

                }

            }
            else {

                MessageBox.Show("Empty text Box !");
            }
        }

        private void Imagecompress_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileCompression FC = new FileCompression();
            this.Hide();
            FC.Show();
        }
    }
}
