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
    public partial class BigramEnterForm : Form
    {

        public string alph1 = "";
        public string alph2 = "";
        public string alph3 = "";
        public string alph4 = "";

        public BigramEnterForm()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                alph1 = textBox1.Text + textBox2.Text + textBox3.Text +
                    textBox4.Text + textBox5.Text + textBox6.Text +
                    textBox7.Text + textBox8.Text + textBox9.Text +
                    textBox10.Text + textBox11.Text + textBox12.Text +
                    textBox13.Text + textBox14.Text + textBox15.Text +
                    textBox16.Text + textBox17.Text + textBox18.Text +
                    textBox19.Text + textBox20.Text + textBox21.Text +
                    textBox22.Text + textBox23.Text + textBox24.Text +
                    textBox25.Text + textBox26.Text + textBox27.Text;
                alph2 = textBox28.Text + textBox29.Text + textBox30.Text +
                    textBox31.Text + textBox32.Text + textBox33.Text +
                    textBox34.Text + textBox35.Text + textBox36.Text +
                    textBox37.Text + textBox38.Text + textBox39.Text +
                    textBox40.Text + textBox41.Text + textBox42.Text +
                    textBox43.Text + textBox44.Text + textBox45.Text +
                    textBox46.Text + textBox47.Text + textBox48.Text +
                    textBox49.Text + textBox50.Text + textBox51.Text +
                    textBox52.Text + textBox53.Text + textBox54.Text;
                alph3 = textBox55.Text + textBox56.Text + textBox57.Text +
                    textBox58.Text + textBox59.Text + textBox60.Text +
                    textBox61.Text + textBox62.Text + textBox63.Text +
                    textBox64.Text + textBox65.Text + textBox66.Text +
                    textBox67.Text + textBox68.Text + textBox69.Text +
                    textBox70.Text + textBox71.Text + textBox72.Text +
                    textBox73.Text + textBox74.Text + textBox75.Text +
                    textBox76.Text + textBox77.Text + textBox78.Text +
                    textBox79.Text + textBox80.Text + textBox81.Text;
                alph4 = textBox82.Text + textBox83.Text + textBox84.Text +
                    textBox85.Text + textBox86.Text + textBox87.Text +
                    textBox88.Text + textBox89.Text + textBox90.Text +
                    textBox91.Text + textBox92.Text + textBox93.Text +
                    textBox94.Text + textBox95.Text + textBox96.Text +
                    textBox97.Text + textBox98.Text + textBox99.Text +
                    textBox100.Text + textBox101.Text + textBox102.Text +
                    textBox103.Text + textBox104.Text + textBox105.Text +
                    textBox106.Text + textBox107.Text + textBox108.Text;
                alph1 = alph1.ToUpper();
                alph2 = alph2.ToUpper();
                alph3 = alph3.ToUpper();
                alph4 = alph4.ToUpper();
                if (alph1.Length != 27)
                {
                    throw new Exception("You have you missed a symbol in the upper-left matrix.");
                }
                if (alph2.Length != 27)
                {
                    throw new Exception("You have you missed a symbol in the upper-right matrix.");
                }
                if (alph3.Length != 27)
                {
                    throw new Exception("You have you missed a symbol in the down-left matrix.");
                }
                if (alph4.Length != 27)
                {
                    throw new Exception("You have you missed a symbol in the down-right matrix.");
                }
                foreach (char ch in alph1)
                {
                    if (alph1.IndexOf(ch) != alph1.LastIndexOf(ch))
                    {
                        throw new Exception("Your key consist of two or more equal symbols " + ch + "(upper-left matrix)");
                    }
                    if ((ch < 'A' || ch > 'Z') & (ch != ' '))
                    {
                        throw new Exception("You have entered not-valid symbol: " + ch + "(upper-left matrix)");
                    }
                }
                foreach (char ch in alph2)
                {
                    if (alph2.IndexOf(ch) != alph2.LastIndexOf(ch))
                    {
                        throw new Exception("Your key consist of two or more equal symbols " + ch + "(upper-right matrix)");
                    }
                    if ((ch < 'A' || ch > 'Z') & (ch != ' '))
                    {
                        throw new Exception("You have entered not-valid symbol: " + ch + "(upper-left matrix)");
                    }
                }
                foreach (char ch in alph3)
                {
                    if (alph3.IndexOf(ch) != alph3.LastIndexOf(ch))
                    {
                        throw new Exception("Your key consist of two or more equal symbols " + ch + "(down-left matrix)");
                    }
                    if ((ch < 'A' || ch > 'Z') & (ch != ' '))
                    {
                        throw new Exception("You have entered not-valid symbol: " + ch + "(down-left matrix)");
                    }
                }
                foreach (char ch in alph4)
                {
                    if (alph4.IndexOf(ch) != alph4.LastIndexOf(ch))
                    {
                        throw new Exception("Your key consist of two or more equal symbols " + ch + "(down-right matrix)");
                    }
                    if ((ch < 'A' || ch > 'Z') & (ch != ' '))
                    {
                        throw new Exception("You have entered not-valid symbol: " + ch + "(down-right matrix)");
                    }
                }
                Cipher.key += alph1 + "*" + alph2 + "*" + alph3 + "*" + alph4;
                Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                alph1 = "";
                alph2 = "";
                alph3 = "";
                alph4 = "";
            }
        }
    }
}
