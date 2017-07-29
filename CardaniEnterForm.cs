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
    public partial class CardaniEnterForm : Form
    {
        int N = 4;
        Button[,] mas;
        public string coordinates = "";

        public CardaniEnterForm()
        {
            InitializeComponent();
        }

        public CardaniEnterForm(int N)
        {
            this.N = N;
            if(this.N < 4)
            {
                this.N = 4;
            }
            mas = new Button[this.N, this.N];
            InitializeComponent();
        }

        private void CardaniEnterForm_Load(object sender, EventArgs e)
        {
            switch (N)
            {
                case 5:
                    mas[0, 0] = button00;
                    mas[0, 1] = button01;
                    mas[0, 2] = button02;
                    mas[0, 3] = button03;
                    mas[0, 4] = button04;
                    mas[1, 0] = button10;
                    mas[1, 1] = button11;
                    mas[1, 2] = button12;
                    mas[1, 3] = button13;
                    mas[1, 4] = button14;
                    mas[2, 0] = button20;
                    mas[2, 1] = button21;
                    mas[2, 2] = button22;
                    mas[2, 3] = button23;
                    mas[2, 4] = button24;
                    mas[3, 0] = button30;
                    mas[3, 1] = button31;
                    mas[3, 2] = button32;
                    mas[3, 3] = button33;
                    mas[3, 4] = button34;
                    mas[4, 0] = button40;
                    mas[4, 1] = button41;
                    mas[4, 2] = button42;
                    mas[4, 3] = button43;
                    mas[4, 4] = button44;

                    Size = new Size(MinimumSize.Width + 26, MinimumSize.Height + 26);

                    button00.Visible = true;
                    button01.Visible = true;
                    button02.Visible = true;
                    button03.Visible = true;
                    button04.Visible = true;

                    button10.Visible = true;
                    button11.Visible = true;
                    button12.Visible = true;
                    button13.Visible = true;
                    button14.Visible = true;

                    button20.Visible = true;
                    button21.Visible = true;
                    button22.Visible = true;
                    button23.Visible = true;
                    button24.Visible = true;

                    button30.Visible = true;
                    button31.Visible = true;
                    button32.Visible = true;
                    button33.Visible = true;
                    button34.Visible = true;

                    button40.Visible = true;
                    button41.Visible = true;
                    button42.Visible = true;
                    button43.Visible = true;
                    button44.Visible = true;

                    button00.Enabled = true;
                    button01.Enabled = true;
                    button02.Enabled = true;
                    button03.Enabled = true;
                    button04.Enabled = true;

                    button10.Enabled = true;
                    button11.Enabled = true;
                    button12.Enabled = true;
                    button13.Enabled = true;
                    button14.Enabled = true;

                    button20.Enabled = true;
                    button21.Enabled = true;
                    button22.Enabled = true;
                    button23.Enabled = true;
                    button24.Enabled = true;

                    button30.Enabled = true;
                    button31.Enabled = true;
                    button32.Enabled = true;
                    button33.Enabled = true;
                    button34.Enabled = true;

                    button40.Enabled = true;
                    button41.Enabled = true;
                    button42.Enabled = true;
                    button43.Enabled = true;
                    button44.Enabled = true;

                    break;
                case 6:
                    mas[0, 0] = button00;
                    mas[0, 1] = button01;
                    mas[0, 2] = button02;
                    mas[0, 3] = button03;
                    mas[0, 4] = button04;
                    mas[0, 5] = button05;
                    mas[1, 0] = button10;
                    mas[1, 1] = button11;
                    mas[1, 2] = button12;
                    mas[1, 3] = button13;
                    mas[1, 4] = button14;
                    mas[1, 5] = button15;
                    mas[2, 0] = button20;
                    mas[2, 1] = button21;
                    mas[2, 2] = button22;
                    mas[2, 3] = button23;
                    mas[2, 4] = button24;
                    mas[2, 5] = button25;
                    mas[3, 0] = button30;
                    mas[3, 1] = button31;
                    mas[3, 2] = button32;
                    mas[3, 3] = button33;
                    mas[3, 4] = button34;
                    mas[3, 5] = button35;
                    mas[4, 0] = button40;
                    mas[4, 1] = button41;
                    mas[4, 2] = button42;
                    mas[4, 3] = button43;
                    mas[4, 4] = button44;
                    mas[4, 5] = button45;
                    mas[5, 0] = button50;
                    mas[5, 1] = button51;
                    mas[5, 2] = button52;
                    mas[5, 3] = button53;
                    mas[5, 4] = button54;
                    mas[5, 5] = button55;

                    Size = new Size(MinimumSize.Width + (2 * 26), MinimumSize.Height + (2 * 26));

                    button00.Visible = true;
                    button01.Visible = true;
                    button02.Visible = true;
                    button03.Visible = true;
                    button04.Visible = true;
                    button05.Visible = true;

                    button10.Visible = true;
                    button11.Visible = true;
                    button12.Visible = true;
                    button13.Visible = true;
                    button14.Visible = true;
                    button15.Visible = true;

                    button20.Visible = true;
                    button21.Visible = true;
                    button22.Visible = true;
                    button23.Visible = true;
                    button24.Visible = true;
                    button25.Visible = true;

                    button30.Visible = true;
                    button31.Visible = true;
                    button32.Visible = true;
                    button33.Visible = true;
                    button34.Visible = true;
                    button35.Visible = true;

                    button40.Visible = true;
                    button41.Visible = true;
                    button42.Visible = true;
                    button43.Visible = true;
                    button44.Visible = true;
                    button45.Visible = true;

                    button50.Visible = true;
                    button51.Visible = true;
                    button52.Visible = true;
                    button53.Visible = true;
                    button54.Visible = true;
                    button55.Visible = true;

                    button00.Enabled = true;
                    button01.Enabled = true;
                    button02.Enabled = true;
                    button03.Enabled = true;
                    button04.Enabled = true;
                    button05.Enabled = true;

                    button10.Enabled = true;
                    button11.Enabled = true;
                    button12.Enabled = true;
                    button13.Enabled = true;
                    button14.Enabled = true;
                    button15.Enabled = true;

                    button20.Enabled = true;
                    button21.Enabled = true;
                    button22.Enabled = true;
                    button23.Enabled = true;
                    button24.Enabled = true;
                    button25.Enabled = true;

                    button30.Enabled = true;
                    button31.Enabled = true;
                    button32.Enabled = true;
                    button33.Enabled = true;
                    button34.Enabled = true;
                    button35.Enabled = true;

                    button40.Enabled = true;
                    button41.Enabled = true;
                    button42.Enabled = true;
                    button43.Enabled = true;
                    button44.Enabled = true;
                    button45.Enabled = true;

                    button50.Enabled = true;
                    button51.Enabled = true;
                    button52.Enabled = true;
                    button53.Enabled = true;
                    button54.Enabled = true;
                    button55.Enabled = true;

                    break;
                case 7:
                    mas[0, 0] = button00;
                    mas[0, 1] = button01;
                    mas[0, 2] = button02;
                    mas[0, 3] = button03;
                    mas[0, 4] = button04;
                    mas[0, 5] = button05;
                    mas[0, 6] = button06;
                    mas[1, 0] = button10;
                    mas[1, 1] = button11;
                    mas[1, 2] = button12;
                    mas[1, 3] = button13;
                    mas[1, 4] = button14;
                    mas[1, 5] = button15;
                    mas[1, 6] = button16;
                    mas[2, 0] = button20;
                    mas[2, 1] = button21;
                    mas[2, 2] = button22;
                    mas[2, 3] = button23;
                    mas[2, 4] = button24;
                    mas[2, 5] = button25;
                    mas[2, 6] = button26;
                    mas[3, 0] = button30;
                    mas[3, 1] = button31;
                    mas[3, 2] = button32;
                    mas[3, 3] = button33;
                    mas[3, 4] = button34;
                    mas[3, 5] = button35;
                    mas[3, 6] = button36;
                    mas[4, 0] = button40;
                    mas[4, 1] = button41;
                    mas[4, 2] = button42;
                    mas[4, 3] = button43;
                    mas[4, 4] = button44;
                    mas[4, 5] = button45;
                    mas[4, 6] = button46;
                    mas[5, 0] = button50;
                    mas[5, 1] = button51;
                    mas[5, 2] = button52;
                    mas[5, 3] = button53;
                    mas[5, 4] = button54;
                    mas[5, 5] = button55;
                    mas[5, 6] = button56;
                    mas[6, 0] = button60;
                    mas[6, 1] = button61;
                    mas[6, 2] = button62;
                    mas[6, 3] = button63;
                    mas[6, 4] = button64;
                    mas[6, 5] = button65;
                    mas[6, 6] = button66;

                    Size = new Size(MinimumSize.Width + (3 * 26), MinimumSize.Height + (3 * 26));

                    button00.Visible = true;
                    button01.Visible = true;
                    button02.Visible = true;
                    button03.Visible = true;
                    button04.Visible = true;
                    button05.Visible = true;
                    button06.Visible = true;

                    button10.Visible = true;
                    button11.Visible = true;
                    button12.Visible = true;
                    button13.Visible = true;
                    button14.Visible = true;
                    button15.Visible = true;
                    button16.Visible = true;

                    button20.Visible = true;
                    button21.Visible = true;
                    button22.Visible = true;
                    button23.Visible = true;
                    button24.Visible = true;
                    button25.Visible = true;
                    button26.Visible = true;

                    button30.Visible = true;
                    button31.Visible = true;
                    button32.Visible = true;
                    button33.Visible = true;
                    button34.Visible = true;
                    button35.Visible = true;
                    button36.Visible = true;

                    button40.Visible = true;
                    button41.Visible = true;
                    button42.Visible = true;
                    button43.Visible = true;
                    button44.Visible = true;
                    button45.Visible = true;
                    button46.Visible = true;

                    button50.Visible = true;
                    button51.Visible = true;
                    button52.Visible = true;
                    button53.Visible = true;
                    button54.Visible = true;
                    button55.Visible = true;
                    button56.Visible = true;

                    button60.Visible = true;
                    button61.Visible = true;
                    button62.Visible = true;
                    button63.Visible = true;
                    button64.Visible = true;
                    button65.Visible = true;
                    button66.Visible = true;

                    button00.Enabled = true;
                    button01.Enabled = true;
                    button02.Enabled = true;
                    button03.Enabled = true;
                    button04.Enabled = true;
                    button05.Enabled = true;
                    button06.Enabled = true;

                    button10.Enabled = true;
                    button11.Enabled = true;
                    button12.Enabled = true;
                    button13.Enabled = true;
                    button14.Enabled = true;
                    button15.Enabled = true;
                    button16.Enabled = true;

                    button20.Enabled = true;
                    button21.Enabled = true;
                    button22.Enabled = true;
                    button23.Enabled = true;
                    button24.Enabled = true;
                    button25.Enabled = true;
                    button26.Enabled = true;

                    button30.Enabled = true;
                    button31.Enabled = true;
                    button32.Enabled = true;
                    button33.Enabled = true;
                    button34.Enabled = true;
                    button35.Enabled = true;
                    button36.Enabled = true;

                    button40.Enabled = true;
                    button41.Enabled = true;
                    button42.Enabled = true;
                    button43.Enabled = true;
                    button44.Enabled = true;
                    button45.Enabled = true;
                    button46.Enabled = true;

                    button50.Enabled = true;
                    button51.Enabled = true;
                    button52.Enabled = true;
                    button53.Enabled = true;
                    button54.Enabled = true;
                    button55.Enabled = true;
                    button56.Enabled = true;

                    button60.Enabled = true;
                    button61.Enabled = true;
                    button62.Enabled = true;
                    button63.Enabled = true;
                    button64.Enabled = true;
                    button65.Enabled = true;
                    button66.Enabled = true;

                    break;
                case 8:
                    mas[0, 0] = button00;
                    mas[0, 1] = button01;
                    mas[0, 2] = button02;
                    mas[0, 3] = button03;
                    mas[0, 4] = button04;
                    mas[0, 5] = button05;
                    mas[0, 6] = button06;
                    mas[0, 7] = button07;
                    mas[1, 0] = button10;
                    mas[1, 1] = button11;
                    mas[1, 2] = button12;
                    mas[1, 3] = button13;
                    mas[1, 4] = button14;
                    mas[1, 5] = button15;
                    mas[1, 6] = button16;
                    mas[1, 7] = button17;
                    mas[2, 0] = button20;
                    mas[2, 1] = button21;
                    mas[2, 2] = button22;
                    mas[2, 3] = button23;
                    mas[2, 4] = button24;
                    mas[2, 5] = button25;
                    mas[2, 6] = button26;
                    mas[2, 7] = button27;
                    mas[3, 0] = button30;
                    mas[3, 1] = button31;
                    mas[3, 2] = button32;
                    mas[3, 3] = button33;
                    mas[3, 4] = button34;
                    mas[3, 5] = button35;
                    mas[3, 6] = button36;
                    mas[3, 7] = button37;
                    mas[4, 0] = button40;
                    mas[4, 1] = button41;
                    mas[4, 2] = button42;
                    mas[4, 3] = button43;
                    mas[4, 4] = button44;
                    mas[4, 5] = button45;
                    mas[4, 6] = button46;
                    mas[4, 7] = button47;
                    mas[5, 0] = button50;
                    mas[5, 1] = button51;
                    mas[5, 2] = button52;
                    mas[5, 3] = button53;
                    mas[5, 4] = button54;
                    mas[5, 5] = button55;
                    mas[5, 6] = button56;
                    mas[5, 7] = button57;
                    mas[6, 0] = button60;
                    mas[6, 1] = button61;
                    mas[6, 2] = button62;
                    mas[6, 3] = button63;
                    mas[6, 4] = button64;
                    mas[6, 5] = button65;
                    mas[6, 6] = button66;
                    mas[6, 7] = button67;
                    mas[7, 0] = button70;
                    mas[7, 1] = button71;
                    mas[7, 2] = button72;
                    mas[7, 3] = button73;
                    mas[7, 4] = button74;
                    mas[7, 5] = button75;
                    mas[7, 6] = button76;
                    mas[7, 7] = button77;

                    button00.Visible = true;
                    button01.Visible = true;
                    button02.Visible = true;
                    button03.Visible = true;
                    button04.Visible = true;
                    button05.Visible = true;
                    button06.Visible = true;
                    button07.Visible = true;

                    button10.Visible = true;
                    button11.Visible = true;
                    button12.Visible = true;
                    button13.Visible = true;
                    button14.Visible = true;
                    button15.Visible = true;
                    button16.Visible = true;
                    button17.Visible = true;

                    button20.Visible = true;
                    button21.Visible = true;
                    button22.Visible = true;
                    button23.Visible = true;
                    button24.Visible = true;
                    button25.Visible = true;
                    button26.Visible = true;
                    button27.Visible = true;

                    button30.Visible = true;
                    button31.Visible = true;
                    button32.Visible = true;
                    button33.Visible = true;
                    button34.Visible = true;
                    button35.Visible = true;
                    button36.Visible = true;
                    button37.Visible = true;

                    button40.Visible = true;
                    button41.Visible = true;
                    button42.Visible = true;
                    button43.Visible = true;
                    button44.Visible = true;
                    button45.Visible = true;
                    button46.Visible = true;
                    button47.Visible = true;

                    button50.Visible = true;
                    button51.Visible = true;
                    button52.Visible = true;
                    button53.Visible = true;
                    button54.Visible = true;
                    button55.Visible = true;
                    button56.Visible = true;
                    button57.Visible = true;

                    button60.Visible = true;
                    button61.Visible = true;
                    button62.Visible = true;
                    button63.Visible = true;
                    button64.Visible = true;
                    button65.Visible = true;
                    button66.Visible = true;
                    button67.Visible = true;

                    button70.Visible = true;
                    button71.Visible = true;
                    button72.Visible = true;
                    button73.Visible = true;
                    button74.Visible = true;
                    button75.Visible = true;
                    button76.Visible = true;
                    button77.Visible = true;

                    button00.Enabled = true;
                    button01.Enabled = true;
                    button02.Enabled = true;
                    button03.Enabled = true;
                    button04.Enabled = true;
                    button05.Enabled = true;
                    button06.Enabled = true;
                    button07.Enabled = true;

                    button10.Enabled = true;
                    button11.Enabled = true;
                    button12.Enabled = true;
                    button13.Enabled = true;
                    button14.Enabled = true;
                    button15.Enabled = true;
                    button16.Enabled = true;
                    button17.Enabled = true;

                    button20.Enabled = true;
                    button21.Enabled = true;
                    button22.Enabled = true;
                    button23.Enabled = true;
                    button24.Enabled = true;
                    button25.Enabled = true;
                    button26.Enabled = true;
                    button27.Enabled = true;

                    button30.Enabled = true;
                    button31.Enabled = true;
                    button32.Enabled = true;
                    button33.Enabled = true;
                    button34.Enabled = true;
                    button35.Enabled = true;
                    button36.Enabled = true;
                    button37.Enabled = true;

                    button40.Enabled = true;
                    button41.Enabled = true;
                    button42.Enabled = true;
                    button43.Enabled = true;
                    button44.Enabled = true;
                    button45.Enabled = true;
                    button46.Enabled = true;
                    button47.Enabled = true;

                    button50.Enabled = true;
                    button51.Enabled = true;
                    button52.Enabled = true;
                    button53.Enabled = true;
                    button54.Enabled = true;
                    button55.Enabled = true;
                    button56.Enabled = true;
                    button57.Enabled = true;

                    button60.Enabled = true;
                    button61.Enabled = true;
                    button62.Enabled = true;
                    button63.Enabled = true;
                    button64.Enabled = true;
                    button65.Enabled = true;
                    button66.Enabled = true;
                    button67.Enabled = true;

                    button70.Enabled = true;
                    button71.Enabled = true;
                    button72.Enabled = true;
                    button73.Enabled = true;
                    button74.Enabled = true;
                    button75.Enabled = true;
                    button76.Enabled = true;
                    button77.Enabled = true;
                    break;
                default:
                    mas[0, 0] = button00;
                    mas[0, 1] = button01;
                    mas[0, 2] = button02;
                    mas[0, 3] = button03;
                    mas[1, 0] = button10;
                    mas[1, 1] = button11;
                    mas[1, 2] = button12;
                    mas[1, 3] = button13;
                    mas[2, 0] = button20;
                    mas[2, 1] = button21;
                    mas[2, 2] = button22;
                    mas[2, 3] = button23;
                    mas[3, 0] = button30;
                    mas[3, 1] = button31;
                    mas[3, 2] = button32;
                    mas[3, 3] = button33;

                    Size = MinimumSize;

                    button00.Visible = true;
                    button01.Visible = true;
                    button02.Visible = true;
                    button03.Visible = true;

                    button10.Visible = true;
                    button11.Visible = true;
                    button12.Visible = true;
                    button13.Visible = true;

                    button20.Visible = true;
                    button21.Visible = true;
                    button22.Visible = true;
                    button23.Visible = true;

                    button30.Visible = true;
                    button31.Visible = true;
                    button32.Visible = true;
                    button33.Visible = true;

                    button00.Enabled = true;
                    button01.Enabled = true;
                    button02.Enabled = true;
                    button03.Enabled = true;

                    button10.Enabled = true;
                    button11.Enabled = true;
                    button12.Enabled = true;
                    button13.Enabled = true;

                    button20.Enabled = true;
                    button21.Enabled = true;
                    button22.Enabled = true;
                    button23.Enabled = true;

                    button30.Enabled = true;
                    button31.Enabled = true;
                    button32.Enabled = true;
                    button33.Enabled = true;

                    break;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < N; i++)
            {
                for (int i2 = 0; i2 < N; i2++)
                {
                    if ((Button)sender == mas[i, i2])
                    {
                        mas[i, i2].Enabled = false;
                        mas[i, i2].BackColor = Color.Green;
                        coordinates += (i+1).ToString() + (i2+1).ToString();

                        mas[i2, N - i - 1].Enabled = false;
                        mas[i2, N - i - 1].BackColor = Color.Green;

                        mas[N - i - 1, N - i2 - 1].Enabled = false;
                        mas[N - i - 1, N - i2 - 1].BackColor = Color.Green;

                        mas[N - i2 - 1, i].Enabled = false;
                        mas[N - i2 - 1, i].BackColor = Color.Green;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Button b in mas)
            {
                if(b.Enabled == true)
                {
                    MessageBox.Show("Haven't you missed something?");
                    goto end;
                }
            }
            Cipher.key = coordinates;
            Cipher.N = N;
            System.IO.StreamWriter W = new System.IO.StreamWriter(@"C:\Users\Serg\Desktop\key10.txt");
            for(int i = 0; i<coordinates.Length; i+=2)
            {
                W.WriteLine(coordinates[i] + " " + coordinates[i + 1]);
            }
            W.Close();
            Close();
            end:;
        }
    }
}
