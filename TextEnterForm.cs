using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cipher
{
    public partial class TextEnterForm : Form
    {

        public TextEnterForm()
        {
            InitializeComponent();
        }

        public string text = "";

        private void enterButton_Click(object sender, EventArgs e)
        {
            text = textBox.Text.ToUpper();
            try
            {
                if (text != "")
                {
                    foreach (char c in text)
                    {
                        if ((c < 'A' || c > 'Z') & (c != ' ') & !char.IsDigit(c))
                        {
                            throw new Exception("You have entered not-valid symbol: " + c);
                        }
                    }
                    Cipher.key += text;
                    Close();
                }
                else
                {
                    throw new Exception("You haven't entered a key...");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                text = "";
            }
        }

        private void textBox_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
        }
    }
}
