using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using IsSimpleNumber;

namespace Cipher
{
    public partial class RSAEnterForm : Form
    {
        public RSAEnterForm(bool cipher = false)
        {
            InitializeComponent();
            if (cipher)
            {
                pTextBox.Enabled = false;
                qTextBox.Enabled = false;
            }
        }

        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            string s = ((TextBox)sender).Text.ToString();
            foreach(char c in s)
            {
                if (!char.IsDigit(c))
                {
                    e.Cancel = true;
                    MessageBox.Show("Key should contain only digits!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Class.IsSimple(uint.Parse(eTextBox.Text)) ||
               !Class.IsSimple(uint.Parse(nTextBox.Text)) ||
               (pTextBox.Enabled && !Class.IsSimple(uint.Parse(pTextBox.Text))) ||
               (qTextBox.Enabled && !Class.IsSimple(uint.Parse(qTextBox.Text))))
            {
                MessageBox.Show("Only simple numbers are allowed as keys! Note: simple number - number which dividers are only 1 and number itself.");
            }
            else
            {
                Cipher.key = eTextBox.Text + " " + nTextBox.Text + " " + qTextBox.Text + " " + pTextBox.Text;
            }
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            MessageBox.Show("You haven't entered any valid key.");
        }
    }
}
