using System;
using System.Windows.Forms;

namespace HK.Data_Encrypt_Decrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void decrypt_textbox_TextChanged(object sender, EventArgs e)
        {
            encrypt_textbox.Text = HK.Security.StringCipher.Decrypt(decrypt_textbox.Text);

        }
        private void encrypt_textbox_TextChanged(object sender, EventArgs e)
        {
            decrypt_textbox.Text = HK.Security.StringCipher.Encrypt(encrypt_textbox.Text);
        }
    }
}
