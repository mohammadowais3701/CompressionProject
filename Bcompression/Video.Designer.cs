namespace Bcompression
{
    partial class Video
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Video));
            this.videotextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mp4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.Gif = new System.Windows.Forms.Button();
            this.wmv = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.webm = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // videotextbox
            // 
            this.videotextbox.Location = new System.Drawing.Point(138, 60);
            this.videotextbox.Multiline = true;
            this.videotextbox.Name = "videotextbox";
            this.videotextbox.Size = new System.Drawing.Size(223, 24);
            this.videotextbox.TabIndex = 0;
            this.videotextbox.TextChanged += new System.EventHandler(this.videotextbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "File";
            // 
            // mp4
            // 
            this.mp4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.mp4.Location = new System.Drawing.Point(169, 109);
            this.mp4.Name = "mp4";
            this.mp4.Size = new System.Drawing.Size(48, 25);
            this.mp4.TabIndex = 2;
            this.mp4.Text = "mp4";
            this.mp4.UseVisualStyleBackColor = false;
            this.mp4.Click += new System.EventHandler(this.mp4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Formet";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(376, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gif
            // 
            this.Gif.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Gif.Location = new System.Drawing.Point(223, 109);
            this.Gif.Name = "Gif";
            this.Gif.Size = new System.Drawing.Size(40, 25);
            this.Gif.TabIndex = 5;
            this.Gif.Text = "gif";
            this.Gif.UseVisualStyleBackColor = false;
            this.Gif.Click += new System.EventHandler(this.Gif_Click);
            // 
            // wmv
            // 
            this.wmv.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.wmv.Location = new System.Drawing.Point(269, 108);
            this.wmv.Name = "wmv";
            this.wmv.Size = new System.Drawing.Size(43, 25);
            this.wmv.TabIndex = 6;
            this.wmv.Text = "wmv";
            this.wmv.UseVisualStyleBackColor = false;
            this.wmv.Click += new System.EventHandler(this.wmv_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.Location = new System.Drawing.Point(318, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 25);
            this.button2.TabIndex = 7;
            this.button2.Text = "mpeg";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // webm
            // 
            this.webm.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.webm.Location = new System.Drawing.Point(367, 108);
            this.webm.Name = "webm";
            this.webm.Size = new System.Drawing.Size(43, 25);
            this.webm.TabIndex = 8;
            this.webm.Text = "webm";
            this.webm.UseVisualStyleBackColor = false;
            this.webm.Click += new System.EventHandler(this.webm_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button3.Location = new System.Drawing.Point(436, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 73);
            this.button3.TabIndex = 9;
            this.button3.Text = "back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bcompression.Properties.Resources.back_video;
            this.ClientSize = new System.Drawing.Size(519, 221);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.webm);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.wmv);
            this.Controls.Add(this.Gif);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mp4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.videotextbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Video";
            this.Text = "Video";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox videotextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mp4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Gif;
        private System.Windows.Forms.Button wmv;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button webm;
        private System.Windows.Forms.Button button3;
    }
}