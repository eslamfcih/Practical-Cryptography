using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security_TASK
{
    public partial class AES : Form
    {
        string ImageUrl = null;


        public AES()
        {
            InitializeComponent();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "JPG|*.jpg|JPEG|*.jpeg|PNG|*.png";
            if (file.ShowDialog() == DialogResult.OK)
            {
                ImageUrl = file.FileName;
                OImage.Image = Image.FromFile(file.FileName);
            }
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            var aes = new AesEncryption();
            var key = aes.GenerateRandomNumber(32);
            var iv = aes.GenerateRandomNumber(16);
            Image I = OImage.Image;
            var data = ImageToByteArray(I);
            var encrypted = aes.Encrypt(data, key, iv);
            var encryptedMessage = Encoding.UTF8.GetString(encrypted);
            EncryptedMessage.Text = encryptedMessage;
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            var aes = new AesEncryption();
            var key = aes.GenerateRandomNumber(32);
            var iv = aes.GenerateRandomNumber(16);
            Image I = OImage.Image;
            var data = ImageToByteArray(I);
            var encrypted = aes.Encrypt(data, key, iv);
            var decrypted = aes.Decrypt(encrypted, key, iv);
            var decryptedMessage = Encoding.UTF8.GetString(decrypted);
            Image II = byteArrayToImage(decrypted);
            DecryptedImage.Image = II;


        }
     private byte[] ImageToByteArray(Image imageIn)
          {
              //this function coverts the image into a byte array to be sent later to the decryptor
              using (var ms = new MemoryStream())
              {
                 imageIn.Save(ms, imageIn.RawFormat);//saving the image byte into the memory strem of ms

                  return ms.ToArray(); //returning the image as byte array 
              }
          }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {

            using (var ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }

        }

        
    }
}
