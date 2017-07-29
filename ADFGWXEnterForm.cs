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
    public partial class ADFGWXEnterForm : Form
    {
        string key1 = "";
        string key2 = "";

        public ADFGWXEnterForm()
        {
            InitializeComponent();
        }

        private void ADFGWXEnterForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            key1 = AA.Text + AD.Text + AF.Text + AG.Text + AW.Text + AX.Text +
                DA.Text + DD.Text + DF.Text + DG.Text + DW.Text + DX.Text +
                FA.Text + FD.Text + FF.Text + FG.Text + FW.Text + FX.Text +
                GA.Text + GD.Text + GF.Text + GG.Text + GW.Text + GX.Text +
                WA.Text + WD.Text + WF.Text + WG.Text + WW.Text + WX.Text +
                XA.Text + XD.Text + XF.Text + XG.Text + XW.Text + XX.Text;
            foreach (char c in key1)
            {
                if (key1.IndexOf(c) != key1.LastIndexOf(c))
                {
                    MessageBox.Show("You have entered two or more equal symbols.");
                    goto end;
                }
            }
            key2 = key2TextBox.Text;
            for (int i = 1; i <= key2.Length; i++)
            {
                if (key2.IndexOf(i.ToString()) == -1)
                {
                    MessageBox.Show("You have entered invalid code");
                    goto end;
                }
            }
            Cipher.key = key1.ToUpper() + "*" + key2;
            System.IO.StreamWriter W = new System.IO.StreamWriter(@"C:\Users\Serg\Desktop\key12.txt");
            for(int i = 0; i<36; i+=6)
            {
                W.WriteLine(key1.Substring(i, 6).ToUpper());
            }
            W.WriteLine(key2);
            W.Close();
            Close();
            end:;
        }
    }
}
