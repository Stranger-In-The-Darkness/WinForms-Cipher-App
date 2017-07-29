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
    public partial class SubstitutionEnterForm : Form
    {
        public string alph = "";

        public SubstitutionEnterForm()
        {
            InitializeComponent();
        }

        private void readyButton_Click(object sender, EventArgs e)
        {
            try
            {
                alph += textBox28.Text + textBox29.Text + textBox30.Text +
                    textBox31.Text + textBox32.Text + textBox33.Text +
                    textBox34.Text + textBox35.Text + textBox36.Text +
                    textBox37.Text + textBox38.Text + textBox39.Text +
                    textBox40.Text + textBox41.Text + textBox42.Text +
                    textBox43.Text + textBox44.Text + textBox45.Text +
                    textBox46.Text + textBox47.Text + textBox48.Text +
                    textBox49.Text + textBox50.Text + textBox51.Text +
                    textBox52.Text + textBox53.Text + textBox54.Text;
                alph.ToUpper();
                if (alph.Length != 27)
                {
                    throw new Exception("Your key is too short! Have you missed any symbol?");
                }
                foreach (char ch in alph)
                {
                    if (alph.IndexOf(ch) != alph.LastIndexOf(ch))
                    {
                        throw new Exception("Your key consist of two or more equal symbols " + ch);
                    }
                    if ((ch < 'A' || ch > 'Z') & (ch != ' '))
                    {
                        throw new Exception("You have entered not-valid symbol: " + ch);
                    }
                    Cipher.key += alph;
                    Close();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                alph = "";
            }
        }
    }
}
