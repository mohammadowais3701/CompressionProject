namespace Bcompression
{
    partial class Imagecompress
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Imagecompress));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.compressbtn = new System.Windows.Forms.Button();
            this.decompressbtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(561, 20);
            this.textBox1.TabIndex = 0;
            // 
            // openbtn
            // 
            this.openbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.openbtn.Location = new System.Drawing.Point(12, 36);
            this.openbtn.Name = "openbtn";
            this.openbtn.Size = new System.Drawing.Size(75, 23);
            this.openbtn.TabIndex = 1;
            this.openbtn.Text = "Open";
            this.openbtn.UseVisualStyleBackColor = false;
            this.openbtn.Click += new System.EventHandler(this.openbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 188);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 270);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(264, 187);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // compressbtn
            // 
            this.compressbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.compressbtn.Location = new System.Drawing.Point(315, 127);
            this.compressbtn.Name = "compressbtn";
            this.compressbtn.Size = new System.Drawing.Size(75, 23);
            this.compressbtn.TabIndex = 4;
            this.compressbtn.Text = "Compress";
            this.compressbtn.UseVisualStyleBackColor = false;
            this.compressbtn.Click += new System.EventHandler(this.compressbtn_Click);
            // 
            // decompressbtn
            // 
            this.decompressbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.decompressbtn.Location = new System.Drawing.Point(315, 203);
            this.decompressbtn.Name = "decompressbtn";
            this.decompressbtn.Size = new System.Drawing.Size(75, 23);
            this.decompressbtn.TabIndex = 5;
            this.decompressbtn.Text = "Decompress";
            this.decompressbtn.UseVisualStyleBackColor = false;
            this.decompressbtn.Click += new System.EventHandler(this.decompressbtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Savebtn.Location = new System.Drawing.Point(315, 280);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 23);
            this.Savebtn.TabIndex = 6;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(315, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Imagecompress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bcompression.Properties.Resources.compress_main;
            this.ClientSize = new System.Drawing.Size(707, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.decompressbtn);
            this.Controls.Add(this.compressbtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.openbtn);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Imagecompress";
            this.Text = "Imagecompress";
            this.Load += new System.EventHandler(this.Imagecompress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button openbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button compressbtn;
        private System.Windows.Forms.Button decompressbtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}