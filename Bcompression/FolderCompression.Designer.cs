namespace Bcompression
{
    partial class FolderCompression
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderCompression));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.compressbtn = new System.Windows.Forms.Button();
            this.Extractbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(553, 244);
            this.listBox1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(21, 261);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(148, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Delete File After Archiving";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // compressbtn
            // 
            this.compressbtn.Location = new System.Drawing.Point(230, 254);
            this.compressbtn.Name = "compressbtn";
            this.compressbtn.Size = new System.Drawing.Size(87, 29);
            this.compressbtn.TabIndex = 2;
            this.compressbtn.Text = "Compress";
            this.compressbtn.UseVisualStyleBackColor = true;
            this.compressbtn.Click += new System.EventHandler(this.compressbtn_Click);
            // 
            // Extractbtn
            // 
            this.Extractbtn.Location = new System.Drawing.Point(348, 254);
            this.Extractbtn.Name = "Extractbtn";
            this.Extractbtn.Size = new System.Drawing.Size(87, 29);
            this.Extractbtn.TabIndex = 3;
            this.Extractbtn.Text = "Extract";
            this.Extractbtn.UseVisualStyleBackColor = true;
            this.Extractbtn.Click += new System.EventHandler(this.Extractbtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FolderCompression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 286);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Extractbtn);
            this.Controls.Add(this.compressbtn);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FolderCompression";
            this.Text = "FolderCompression";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button compressbtn;
        private System.Windows.Forms.Button Extractbtn;
        private System.Windows.Forms.Button button1;
    }
}