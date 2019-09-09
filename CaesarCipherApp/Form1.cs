using System;
using System.Windows.Forms;

namespace CaesarCipherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            var shift = 0;

            if (!string.IsNullOrWhiteSpace(textToEncrypt.Text) && int.TryParse(charShift.Text, out shift))
            {
                if (decryptRB.Checked)
                {
                    shift = shift * -1;
                }

                cipher.Text = CaesarCipher.Encrypt(textToEncrypt.Text, shift);
            }
            else
            {
                textToEncrypt.Text = "INVALID FORM DATA";
            }
        }

        private void radioButtons_Click(object sender, EventArgs e)
        {
            if (encryptRB.Checked)
            {
                textToEncrypt.Text = "Text to encrypt";
                encryptBtn.Text = "Encrypt";
            }
            else if (decryptRB.Checked)
            {
                textToEncrypt.Text = "Text to decrypt";
                encryptBtn.Text = "Decrypt";
            }
        }
    }
}
