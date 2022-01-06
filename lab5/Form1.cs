using System;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static lab5.ErrorHandling;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Compress(Stream stream, byte[] buffer)
        {
            using (DeflateStream deflateStream = new DeflateStream(stream, CompressionLevel.Optimal))
            {
                deflateStream.Write(buffer, 0, buffer.Length);
            }
        }

        private void Decompress(Stream stream, byte[] buffer)
        {
            using (DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress))
            {
                deflateStream.Read(buffer, 0, buffer.Length);
            }
        }

        private void Encrypt(Stream stream, byte[] buffer)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            des.Key = Encoding.UTF8.GetBytes("123");
            des.IV = Encoding.UTF8.GetBytes("123");

            using (CryptoStream cryptoStream = new CryptoStream(stream, des.CreateEncryptor(), CryptoStreamMode.Write))
            {
                cryptoStream.Write(buffer, 0, buffer.Length);
            }
        }

        private void Decrypt(Stream stream, byte[] buffer)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            des.Key = Encoding.UTF8.GetBytes("123");
            des.IV = Encoding.UTF8.GetBytes("123");

            using (CryptoStream cryptoStream = new CryptoStream(stream, des.CreateDecryptor(des.Key, des.IV), CryptoStreamMode.Read))
            {
                cryptoStream.Read(buffer, 0, buffer.Length);
            }
        }

        private void browse_bt_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            path_tb.Text = openFileDialog.FileName;
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Read(compressionToolStripMenuItem.Checked, encryptionToolStripMenuItem.Checked);
            }
            catch
            {
                EmptyPathError();
            }
        }

        private void Read(bool compression, bool encryption)
        {
            using (FileStream fileStream = new FileStream(path_tb.Text, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[fileStream.Length];

                if (compression && encryption)
                {
                    using (DeflateStream deflateStream = new DeflateStream(fileStream, CompressionMode.Decompress))
                    {
                        Decrypt(deflateStream, buffer);
                    }
                }
                else
                {
                    if (compression)
                    {
                        Decompress(fileStream, buffer);
                    }
                    else
                    {
                        if (encryption)
                        {
                            Decrypt(fileStream, buffer);
                        }
                        else
                        {
                            fileStream.Read(buffer, 0, buffer.Length);
                        }
                    }
                }

                fileContent_rtb.Text = Encoding.UTF8.GetString(buffer);
            }
        }

        private void writeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Write(compressionToolStripMenuItem.Checked, encryptionToolStripMenuItem.Checked);
            }
            catch
            {
                EmptyPathError();
            }
        }             

        private void Write(bool compression, bool encryption)
        {
            using (FileStream fileStream = new FileStream(path_tb.Text, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = Encoding.UTF8.GetBytes(fileContent_rtb.Text);

                if (compression && encryption)
                {
                    using (DeflateStream deflateStream = new DeflateStream(fileStream, CompressionLevel.Optimal))
                    {
                        Encrypt(deflateStream, buffer);
                    }
                }
                else
                {
                    if (compression)
                    {
                        Compress(fileStream, buffer);
                    }
                    else
                    {
                        if (encryption)
                        {
                            Encrypt(fileStream, buffer);
                        }
                        else
                        {
                            fileStream.Write(buffer, 0, buffer.Length);
                        }
                    }
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileContent_rtb.Clear();
        }
    }
}
