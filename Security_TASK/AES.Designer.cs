namespace Security_TASK
{
    partial class AES
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
            this.Browse = new System.Windows.Forms.Button();
            this.OImage = new System.Windows.Forms.PictureBox();
            this.DecryptedImage = new System.Windows.Forms.PictureBox();
            this.Encrypt = new System.Windows.Forms.Button();
            this.Decrypt = new System.Windows.Forms.Button();
            this.EncryptedMessage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.OImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DecryptedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(57, 265);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 0;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // OImage
            // 
            this.OImage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OImage.Location = new System.Drawing.Point(12, 22);
            this.OImage.Name = "OImage";
            this.OImage.Size = new System.Drawing.Size(204, 156);
            this.OImage.TabIndex = 1;
            this.OImage.TabStop = false;
            // 
            // DecryptedImage
            // 
            this.DecryptedImage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DecryptedImage.Location = new System.Drawing.Point(537, 22);
            this.DecryptedImage.Name = "DecryptedImage";
            this.DecryptedImage.Size = new System.Drawing.Size(204, 156);
            this.DecryptedImage.TabIndex = 3;
            this.DecryptedImage.TabStop = false;
            // 
            // Encrypt
            // 
            this.Encrypt.Location = new System.Drawing.Point(352, 265);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(75, 23);
            this.Encrypt.TabIndex = 4;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.Location = new System.Drawing.Point(600, 265);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(75, 23);
            this.Decrypt.TabIndex = 5;
            this.Decrypt.Text = "Decrypt";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // EncryptedMessage
            // 
            this.EncryptedMessage.Location = new System.Drawing.Point(294, 12);
            this.EncryptedMessage.Multiline = true;
            this.EncryptedMessage.Name = "EncryptedMessage";
            this.EncryptedMessage.Size = new System.Drawing.Size(203, 177);
            this.EncryptedMessage.TabIndex = 6;
            // 
            // AES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 494);
            this.Controls.Add(this.EncryptedMessage);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.DecryptedImage);
            this.Controls.Add(this.OImage);
            this.Controls.Add(this.Browse);
            this.Name = "AES";
            this.Text = "AES";
            ((System.ComponentModel.ISupportInitialize)(this.OImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DecryptedImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.PictureBox OImage;
        private System.Windows.Forms.PictureBox DecryptedImage;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.TextBox EncryptedMessage;

    }
}

