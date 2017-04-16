namespace DES
{
    partial class DES
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
            this.EncryptedMessage = new System.Windows.Forms.TextBox();
            this.Decrypt = new System.Windows.Forms.Button();
            this.Encrypt = new System.Windows.Forms.Button();
            this.DecryptedImage = new System.Windows.Forms.PictureBox();
            this.OImage = new System.Windows.Forms.PictureBox();
            this.Browse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DecryptedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OImage)).BeginInit();
            this.SuspendLayout();
            // 
            // EncryptedMessage
            // 
            this.EncryptedMessage.Location = new System.Drawing.Point(312, 69);
            this.EncryptedMessage.Multiline = true;
            this.EncryptedMessage.Name = "EncryptedMessage";
            this.EncryptedMessage.Size = new System.Drawing.Size(203, 177);
            this.EncryptedMessage.TabIndex = 12;
            // 
            // Decrypt
            // 
            this.Decrypt.Location = new System.Drawing.Point(618, 322);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(75, 23);
            this.Decrypt.TabIndex = 11;
            this.Decrypt.Text = "Decrypt";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // Encrypt
            // 
            this.Encrypt.Location = new System.Drawing.Point(370, 322);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(75, 23);
            this.Encrypt.TabIndex = 10;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // DecryptedImage
            // 
            this.DecryptedImage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DecryptedImage.Location = new System.Drawing.Point(555, 79);
            this.DecryptedImage.Name = "DecryptedImage";
            this.DecryptedImage.Size = new System.Drawing.Size(204, 156);
            this.DecryptedImage.TabIndex = 9;
            this.DecryptedImage.TabStop = false;
            // 
            // OImage
            // 
            this.OImage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OImage.Location = new System.Drawing.Point(30, 79);
            this.OImage.Name = "OImage";
            this.OImage.Size = new System.Drawing.Size(204, 156);
            this.OImage.TabIndex = 8;
            this.OImage.TabStop = false;
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(75, 322);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 7;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // DES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 414);
            this.Controls.Add(this.EncryptedMessage);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.DecryptedImage);
            this.Controls.Add(this.OImage);
            this.Controls.Add(this.Browse);
            this.Name = "DES";
            this.Text = "DES";
            ((System.ComponentModel.ISupportInitialize)(this.DecryptedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EncryptedMessage;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.PictureBox DecryptedImage;
        private System.Windows.Forms.PictureBox OImage;
        private System.Windows.Forms.Button Browse;
    }
}

