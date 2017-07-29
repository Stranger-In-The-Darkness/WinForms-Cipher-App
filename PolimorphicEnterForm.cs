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
    public partial class PolimorphicEnterForm : Form
    {
        public string alph = "";
        int N = 3;
        TextBox[,] box;

        public PolimorphicEnterForm()
        {
            InitializeComponent();
        }

        private void readyButton_Click(object sender, EventArgs e)
        {
            alph += A1.Text + "," + A2.Text + "," + A3.Text + "," + A4.Text + "," + A5.Text + ";" +
                    B1.Text + "," + B2.Text + "," + B3.Text + "," + B4.Text + "," + B5.Text + ";" +
                    C1.Text + "," + C2.Text + "," + C3.Text + "," + C4.Text + "," + C5.Text + ";" +
                    D1.Text + "," + D2.Text + "," + D3.Text + "," + D4.Text + "," + D5.Text + ";" +
                    E1.Text + "," + E2.Text + "," + E3.Text + "," + E4.Text + "," + E5.Text + ";" +
                    F1.Text + "," + F2.Text + "," + F3.Text + "," + F4.Text + "," + F5.Text + ";" +
                    G1.Text + "," + G2.Text + "," + G3.Text + "," + G4.Text + "," + G5.Text + ";" +
                    H1.Text + "," + H2.Text + "," + H3.Text + "," + H4.Text + "," + H5.Text + ";" +
                    I1.Text + "," + I2.Text + "," + I3.Text + "," + I4.Text + "," + I5.Text + ";" +
                    J1.Text + "," + J2.Text + "," + J3.Text + "," + J4.Text + "," + J5.Text + ";" +
                    K1.Text + "," + K2.Text + "," + K3.Text + "," + K4.Text + "," + K5.Text + ";" +
                    L1.Text + "," + L2.Text + "," + L3.Text + "," + L4.Text + "," + L5.Text + ";" +
                    M1.Text + "," + M2.Text + "," + M3.Text + "," + M4.Text + "," + M5.Text + ";" +
                    N1.Text + "," + N2.Text + "," + N3.Text + "," + N4.Text + "," + N5.Text + ";" +
                    O1.Text + "," + O2.Text + "," + O3.Text + "," + O4.Text + "," + O5.Text + ";" +
                    P1.Text + "," + P2.Text + "," + P3.Text + "," + P4.Text + "," + P5.Text + ";" +
                    Q1.Text + "," + Q2.Text + "," + Q3.Text + "," + Q4.Text + "," + Q5.Text + ";" +
                    R1.Text + "," + R2.Text + "," + R3.Text + "," + R4.Text + "," + R5.Text + ";" +
                    S1.Text + "," + S2.Text + "," + S3.Text + "," + S4.Text + "," + S5.Text + ";" +
                    T1.Text + "," + T2.Text + "," + T3.Text + "," + T4.Text + "," + T5.Text + ";" +
                    U1.Text + "," + U2.Text + "," + U3.Text + "," + U4.Text + "," + U5.Text + ";" +
                    V1.Text + "," + V2.Text + "," + V3.Text + "," + V4.Text + "," + V5.Text + ";" +
                    W1.Text + "," + W2.Text + "," + W3.Text + "," + W4.Text + "," + W5.Text + ";" +
                    X1.Text + "," + X2.Text + "," + X3.Text + "," + X4.Text + "," + X5.Text + ";" +
                    Y1.Text + "," + Y2.Text + "," + Y3.Text + "," + Y4.Text + "," + Y5.Text + ";" +
                    Z1.Text + "," + Z2.Text + "," + Z3.Text + "," + Z4.Text + "," + Z5.Text + ";" +
                    Spacebar1.Text + "," + Spacebar2.Text + "," + Spacebar3.Text + "," + Spacebar4.Text + "," + Spacebar5.Text;

            alph = alph.Replace(",,;", ";").Replace(",;", ";").Replace(",,", "");

            foreach (string s in alph.Split(';',','))
            {
                if (s.Length % 3 != 0)
                {
                    MessageBox.Show("You have entered an ivalid code.");
                    goto end;
                }
            }
            foreach (string s in alph.Split(',',';'))
            {
                if(alph.IndexOf(s) != alph.LastIndexOf(s))
                {
                    MessageBox.Show("You have entered two or more same codes: " + s);
                    goto end;
                }
            }
            Cipher.key = alph.Replace(",", "");
            Cipher.N = N;

            System.IO.StreamWriter W = new System.IO.StreamWriter(@"C:\Users\Serg\Desktop\key5.txt");
            W.WriteLine(N);
            W.WriteLine(A1.Text + " " + A2.Text + " " + A3.Text + " " + A4.Text + " " + A5.Text);
            W.WriteLine(B1.Text + " " + B2.Text + " " + B3.Text + " " + B4.Text + " " + B5.Text);
            W.WriteLine(C1.Text + " " + C2.Text + " " + C3.Text + " " + C4.Text + " " + C5.Text);
            W.WriteLine(D1.Text + " " + D2.Text + " " + D3.Text + " " + D4.Text + " " + D5.Text);
            W.WriteLine(E1.Text + " " + E2.Text + " " + E3.Text + " " + E4.Text + " " + E5.Text);
            W.WriteLine(F1.Text + " " + F2.Text + " " + F3.Text + " " + F4.Text + " " + F5.Text);
            W.WriteLine(G1.Text + " " + G2.Text + " " + G3.Text + " " + G4.Text + " " + G5.Text);
            W.WriteLine(H1.Text + " " + H2.Text + " " + H3.Text + " " + H4.Text + " " + H5.Text);
            W.WriteLine(I1.Text + " " + I2.Text + " " + I3.Text + " " + I4.Text + " " + I5.Text);
            W.WriteLine(J1.Text + " " + J2.Text + " " + J3.Text + " " + J4.Text + " " + J5.Text);
            W.WriteLine(K1.Text + " " + K2.Text + " " + K3.Text + " " + K4.Text + " " + K5.Text);
            W.WriteLine(L1.Text + " " + L2.Text + " " + L3.Text + " " + L4.Text + " " + L5.Text);
            W.WriteLine(M1.Text + " " + M2.Text + " " + M3.Text + " " + M4.Text + " " + M5.Text);
            W.WriteLine(N1.Text + " " + N2.Text + " " + N3.Text + " " + N4.Text + " " + N5.Text);
            W.WriteLine(O1.Text + " " + O2.Text + " " + O3.Text + " " + O4.Text + " " + O5.Text);
            W.WriteLine(P1.Text + " " + P2.Text + " " + P3.Text + " " + P4.Text + " " + P5.Text);
            W.WriteLine(Q1.Text + " " + Q2.Text + " " + Q3.Text + " " + Q4.Text + " " + Q5.Text);
            W.WriteLine(R1.Text + " " + R2.Text + " " + R3.Text + " " + R4.Text + " " + R5.Text);
            W.WriteLine(S1.Text + " " + S2.Text + " " + S3.Text + " " + S4.Text + " " + S5.Text);
            W.WriteLine(T1.Text + " " + T2.Text + " " + T3.Text + " " + T4.Text + " " + T5.Text);
            W.WriteLine(U1.Text + " " + U2.Text + " " + U3.Text + " " + U4.Text + " " + U5.Text);
            W.WriteLine(V1.Text + " " + V2.Text + " " + V3.Text + " " + V4.Text + " " + V5.Text);
            W.WriteLine(W1.Text + " " + W2.Text + " " + W3.Text + " " + W4.Text + " " + W5.Text);
            W.WriteLine(X1.Text + " " + X2.Text + " " + X3.Text + " " + X4.Text + " " + X5.Text);
            W.WriteLine(Y1.Text + " " + Y2.Text + " " + Y3.Text + " " + Y4.Text + " " + Y5.Text);
            W.WriteLine(Z1.Text + " " + Z2.Text + " " + Z3.Text + " " + Z4.Text + " " + Z5.Text);
            W.WriteLine(Spacebar1.Text + " " + Spacebar2.Text + " " + Spacebar3.Text + " " + Spacebar4.Text + " " + Spacebar5.Text);

            Close();
            end:;
            alph = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(TextBox t in box)
            {
                t.Enabled = false;
            }
            N = comboBox1.SelectedIndex + 3;
            for(int i = 0; i<27; i++)
            {
                for(int i2 = 0; i2<N; i2++)
                {
                    box[i2, i].Enabled = true;
                }
            }
            readyButton.Enabled = true;
        }

        private void PolimorphicEnterForm_Load(object sender, EventArgs e)
        {
            box = new TextBox[5, 27];

            box[0, 0] = A1;
            box[1, 0] = A2;
            box[2, 0] = A3;
            box[3, 0] = A4;
            box[4, 0] = A5;

            box[0, 1] = B1;
            box[1, 1] = B2;
            box[2, 1] = B3;
            box[3, 1] = B4;
            box[4, 1] = B5;

            box[0, 2] = C1;
            box[1, 2] = C2;
            box[2, 2] = C3;
            box[3, 2] = C4;
            box[4, 2] = C5;
        
            box[0, 3] = D1;
            box[1, 3] = D2;
            box[2, 3] = D3;
            box[3, 3] = D4;
            box[4, 3] = D5;
        
            box[0, 4] = E1;
            box[1, 4] = E2;
            box[2, 4] = E3;
            box[3, 4] = E4;
            box[4, 4] = E5;

            box[0, 5] = F1;
            box[1, 5] = F2;
            box[2, 5] = F3;
            box[3, 5] = F4;
            box[4, 5] = F5;

            box[0, 6] = G1;
            box[1, 6] = G2;
            box[2, 6] = G3;
            box[3, 6] = G4;
            box[4, 6] = G5;

            box[0, 7] = H1;
            box[1, 7] = H2;
            box[2, 7] = H3;
            box[3, 7] = H4;
            box[4, 7] = H5;

            box[0, 8] = I1;
            box[1, 8] = I2;
            box[2, 8] = I3;
            box[3, 8] = I4;
            box[4, 8] = I5;

            box[0, 9] = J1;
            box[1, 9] = J2;
            box[2, 9] = J3;
            box[3, 9] = J4;
            box[4, 9] = J5;
        
            box[0, 10] = K1;
            box[1, 10] = K2;
            box[2, 10] = K3;
            box[3, 10] = K4;
            box[4, 10] = K5;

            box[0, 11] = L1;
            box[1, 11] = L2;
            box[2, 11] = L3;
            box[3, 11] = L4;
            box[4, 11] = L5;

            box[0, 12] = M1;
            box[1, 12] = M2;
            box[2, 12] = M3;
            box[3, 12] = M4;
            box[4, 12] = M5;

            box[0, 13] = N1;
            box[1, 13] = N2;
            box[2, 13] = N3;
            box[3, 13] = N4;
            box[4, 13] = N5;

            box[0, 14] = O1;
            box[1, 14] = O2;
            box[2, 14] = O3;
            box[3, 14] = O4;
            box[4, 14] = O5;

            box[0, 15] = P1;
            box[1, 15] = P2;
            box[2, 15] = P3;
            box[3, 15] = P4;
            box[4, 15] = P5;

            box[0, 16] = Q1;
            box[1, 16] = Q2;
            box[2, 16] = Q3;
            box[3, 16] = Q4;
            box[4, 16] = Q5;

            box[0, 17] = R1;
            box[1, 17] = R2;
            box[2, 17] = R3;
            box[3, 17] = R4;
            box[4, 17] = R5;

            box[0, 18] = S1;
            box[1, 18] = S2;
            box[2, 18] = S3;
            box[3, 18] = S4;
            box[4, 18] = S5;

            box[0, 19] = T1;
            box[1, 19] = T2;
            box[2, 19] = T3;
            box[3, 19] = T4;
            box[4, 19] = T5;

            box[0, 20] = U1;
            box[1, 20] = U2;
            box[2, 20] = U3;
            box[3, 20] = U4;
            box[4, 20] = U5;

            box[0, 21] = V1;
            box[1, 21] = V2;
            box[2, 21] = V3;
            box[3, 21] = V4;
            box[4, 21] = V5;

            box[0, 22] = W1;
            box[1, 22] = W2;
            box[2, 22] = W3;
            box[3, 22] = W4;
            box[4, 22] = W5;

            box[0, 23] = X1;
            box[1, 23] = X2;
            box[2, 23] = X3;
            box[3, 23] = X4;
            box[4, 23] = X5;

            box[0, 24] = Y1;
            box[1, 24] = Y2;
            box[2, 24] = Y3;
            box[3, 24] = Y4;
            box[4, 24] = Y5;

            box[0, 25] = Z1;
            box[1, 25] = Z2;
            box[2, 25] = Z3;
            box[3, 25] = Z4;
            box[4, 25] = Z5;

            box[0, 26] = Spacebar1;
            box[1, 26] = Spacebar2;
            box[2, 26] = Spacebar3;
            box[3, 26] = Spacebar4;
            box[4, 26] = Spacebar5;
        }
    }
}
