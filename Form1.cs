using System;
using System.IO;
using System.Windows.Forms;

namespace Cipher
{
    public partial class Cipher_Main_Form : Form
    {
        int cipher = -1;
        public bool code_decode = false;
        string filePath = "";
        string keyFilePath = "";
        bool saveToFileFlag = false;

        TextEnterForm Form1;
        SubstitutionEnterForm Form2;
        BigramEnterForm Form3;
        PolimorphicEnterForm Form4;
        CardaniEnterForm Form5;
        ADFGWXEnterForm Form6;
        RSAEnterForm Form7;

        public Cipher_Main_Form()
        {
            InitializeComponent();

            Form1 = new TextEnterForm();
            Form2 = new SubstitutionEnterForm();
            Form3 = new BigramEnterForm();
            Form4 = new PolimorphicEnterForm();
            Form5 = new CardaniEnterForm();
            Form6 = new ADFGWXEnterForm();
            Form7 = new RSAEnterForm(code_decode);
        }

        private void textBox_DragDrop(object sender, DragEventArgs e)
        {
            textBox.Text = "";
            foreach (char c in e.Data.GetData(typeof(string)).ToString())
            {
                if (((c > 'Z' || c < 'A') & (c>'9' || c<'0')) || (c != ' '))
                {
                    throw new Exception("Invalid input text.");
                }
            }
            textBox.Text = e.ToString().ToUpper();
        }

        private void textBox_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
        }

        private void codeCheck_CheckedChanged(object sender, EventArgs e)
        {
            code_decode = true;
            enterKeyButton.Enabled = true;
            generateKeyButton.Enabled = true;
        }

        private void decodeCheck_CheckedChanged(object sender, EventArgs e)
        {
            code_decode = false;
            enterKeyButton.Enabled = true;
            generateKeyButton.Enabled = true;
        }

        public void enterKeyButton_Click(object sender, EventArgs e)
        {
            switch (cipher)
            {
                case 0:
                case 2:
                case 3:
                case 4:
                case 5:
                case 8:
                case 10:
                    Form1.Show();
                    Form1 = new TextEnterForm();
                    break;
                case 1:
                    Form2.Show();
                    Form2 = new SubstitutionEnterForm();
                    break;
                case 6:
                    if (code_decode)
                    {
                        Form4.Show();
                        Form4 = new PolimorphicEnterForm();
                    }
                    else
                    {
                        System.IO.StreamReader r = new System.IO.StreamReader(@"C:\Users\Serg\Desktop\key5.txt");
                        Cipher.N = int.Parse(r.ReadLine());
                        string key = "";
                        while (!r.EndOfStream)
                        {
                            key += r.ReadLine().Replace("  ", "") + ";";
                        }
                        r.Close();
                        key.Remove(key.Length - 1, 1);
                        foreach(string s in key.Split(';'))
                        {
                            if (s.Replace(" ", "").Length % 3 != 0)
                            {
                                MessageBox.Show("There's something wrong with your key-file. Please, check it, and try again. (Invalid code)");
                            }
                            foreach(string s2 in s.Split(' '))
                            {
                                if(s2 != "" &&(key.IndexOf(s2) != key.LastIndexOf(s2)))
                                {
                                    MessageBox.Show("There's something wrong with your key-file. Please, check it, and try again. (Two or more same codes " + s2 + ")");
                                }
                            }
                        }
                        Cipher.key = key;
                    }
                    break;
                case 7:
                    if (code_decode)
                    {
                        Form3.Show();
                        Form3 = new BigramEnterForm();
                    }
                    else
                    {
                        System.IO.StreamReader r = new System.IO.StreamReader(@"C:\Users\Serg\Desktop\key8.txt");
                        Cipher.N = int.Parse(r.ReadLine().Replace("\r\n", ""));
                        for (int i = 0; i < 4; i++)
                        {
                            for (int i2 = 0; i2 < 9; i2++)
                            {
                                Cipher.key += r.ReadLine();
                            }
                            Cipher.key += '*';
                        }
                        Cipher.key.Remove(Cipher.key.Length - 2, 1).Replace("\r\n", "");
                    }
                    break;
                case 9:
                    if (code_decode)
                    {
                        if (Math.Sqrt(Cipher.text.Length) % 1.0 != 0) Form5 = new CardaniEnterForm((int)Math.Sqrt(Cipher.text.Length) + 1);
                        else Form5 = new CardaniEnterForm((int)Math.Sqrt(Cipher.text.Length));
                        Form5.Show();
                        Form5 = new CardaniEnterForm();
                    }
                    else
                    {
                        System.IO.StreamReader r = new System.IO.StreamReader(@"C:\Users\Serg\Desktop\key10.txt");
                        Cipher.key = r.ReadToEnd().Replace(" ", "").Replace("\r\n", "");
                        Cipher.N = (int)Math.Sqrt(Cipher.key.Length * 2);
                    }
                    break;
                case 11:
                    if (code_decode)
                    {
                        Form6.Show();
                        Form6 = new ADFGWXEnterForm();
                    }
                    else
                    {
                        System.IO.StreamReader r = new System.IO.StreamReader(@"C:\Users\Serg\Desktop\key12.txt");
                        for(int i = 0; i<6; i++)
                        {
                            Cipher.key += r.ReadLine();
                        }
                        Cipher.key += "*" + r.ReadLine();
                        Cipher.key = Cipher.key.ToUpper();
                        r.Close();
                    }
                    break;
                case 12:
                    Form7.Show();
                    Form7 = new RSAEnterForm(code_decode);
                    break;
            }
            doItButton.Enabled = true;
        }

        private void generateKeyButton_Click(object sender, EventArgs e)
        {
            if (!saveToFileFlag)
            {
                Random rnd = new Random();
                switch (cipher)
                {
                    case 0:
                    case 2:
                    case 3:
                        Cipher.key = rnd.Next().ToString();
                        break;
                    case 4:
                        Cipher.N = rnd.Next(3, 6);
                        for (int i = 0; i < 27; i++)
                        {
                            for(int i2 = 0; i2 < Cipher.N; i2++)
                            {
                                int r = rnd.Next(100, 999);
                                if (Cipher.key.IndexOf(r.ToString()) == -1)
                                {
                                    Cipher.key += r + ",";
                                }
                                else
                                {
                                    i2--;
                                }
                            }
                            Cipher.key += ";";
                            Cipher.key = Cipher.key.Replace(",", "");
                        }
                        break;
                    case 5:
                        for (int i = 0; i < rnd.Next(1, 300); i++)
                        {
                            switch (rnd.Next(0, 1))
                            {
                                case 0:
                                    Cipher.key += (char)rnd.Next('A', 'Z');
                                    break;
                                case 1:
                                    Cipher.key += " ";
                                    break;
                            }
                        }
                        break;
                    case 1:
                        string alph = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                        char[] k = new char[27];
                        for (int i = 0; i < 27; i++)
                        {
                            k[i] = ' ';
                        }
                        for (int j = 0; j < 26; j++)
                        {
                            int index = rnd.Next(0, 25);
                            while (k[index] != ' ')
                            {
                                index++;
                                if (index == 26)
                                {
                                    index = 0;
                                }
                            }
                            if (k[index] == ' ')
                            {
                                int ind = rnd.Next(0, 25);
                                k[index] = alph[ind];
                                alph = alph.Remove(ind, 0);
                            }
                        }
                        foreach (char c in k)
                        {
                            Cipher.key += c;
                        }
                        break;
                    case 6:
                        break;
                    case 7:
                        string alf = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                        char[] k1 = new char[27];
                        char[] k2 = new char[27];
                        char[] k3 = new char[27];
                        char[] k4 = new char[27];
                        for (int i = 0; i < 27; i++)
                        {
                            k1[i] = ' ';
                            k2[i] = ' ';
                            k3[i] = ' ';
                            k4[i] = ' ';
                        }
                        for (int j = 0; j < 26; j++)
                        {
                            int index = rnd.Next(0, 25);
                            while (k1[index] != ' ')
                            {
                                index++;
                                if (index == 26)
                                {
                                    index = 0;
                                }
                            }
                            int ind = rnd.Next(0, 25);
                            k1[index] = alf[ind];
                            alf = alf.Remove(ind, 0);
                        }
                        alf = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                        for (int j = 0; j < 26; j++)
                        {
                            int index = rnd.Next(0, 25);
                            while (k2[index] != ' ')
                            {
                                index++;
                                if (index == 26)
                                {
                                    index = 0;
                                }
                            }
                            if (k2[index] == ' ')
                            {
                                int ind = rnd.Next(0, 25);
                                k2[index] = alf[ind];
                                alf = alf.Remove(ind, 0);
                            }
                        }
                        alf = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                        for (int j = 0; j < 26; j++)
                        {
                            int index = rnd.Next(0, 25);
                            while (k3[index] != ' ')
                            {
                                index++;
                                if (index == 26)
                                {
                                    index = 0;
                                }
                                if (k3[index] == ' ')
                                {
                                    int ind = rnd.Next(0, 25);
                                    k3[index] = alf[ind];
                                    alf = alf.Remove(ind, 0);
                                }
                            }
                        }
                        alf = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                        for (int j = 0; j < 26; j++)
                        {
                            int index = rnd.Next(0, 25);
                            while (k4[index] != ' ')
                            {
                                index++;
                                if (index == 26)
                                {
                                    index = 0;
                                }
                            }
                            if (k4[index] == ' ')
                            {
                                int ind = rnd.Next(0, 25);
                                k4[index] = alf[ind];
                                alf = alf.Remove(ind, 0);
                            }
                        }
                        foreach (char c in k1)
                        {
                            Cipher.key += c;
                        }
                        Cipher.key += "*";
                        foreach (char c in k2)
                        {
                            Cipher.key += c;
                        }
                        Cipher.key += "*";
                        foreach (char c in k3)
                        {
                            Cipher.key += c;
                        }
                        Cipher.key += "*";
                        foreach (char c in k4)
                        {
                            Cipher.key += c;
                        }
                        break;
                    case 8:
                        string num = "123456789";
                        for (int i = 0; i < rnd.Next(2, 9); i++)
                        {
                            Cipher.key += num[rnd.Next(0, num.Length)];
                            num = num.Remove(Cipher.key[Cipher.key.Length - 1], 1);
                        }
                        break;
                    case 9:
                        break;
                    case 10:
                        for (int i = 0; i < Cipher.text.Length * 5; i++)
                        {
                            Cipher.key += rnd.Next(0, 2);
                        }
                        break;
                }
                Cipher.key = Cipher.key.ToUpper();
                enterKeyButton.Visible = false;
                generateKeyButton.Text = "Save to file";
                saveToFileFlag = true;
                enterKeyButton.Enabled = false;
                keyTextBox.Visible = true;
                keyTextBox.Enabled = true;
                keyTextBox.Text = Cipher.key;
                doItButton.Enabled = true;
            }
            else
            {
                switch (cipher)
                {
                    case 4:
                        Cipher.key.Replace(",", "").Replace(";", "");
                        System.IO.StreamWriter W = new System.IO.StreamWriter(@"C:\Users\Serg\Desktop\key5.txt");
                        W.WriteLine(Cipher.N);
                        for (int i = 0; i < 27; i++)
                        {
                            for (int i2 = 0; i2 < Cipher.N * 3; i2 += 3)
                            {
                                W.Write(Cipher.key.Substring(i2, 3) + " ");
                            }
                            W.WriteLine();
                        }
                        W.Close();
                        break;
                    case 5:
                        break;
                    case 7:
                        System.IO.StreamWriter r7 = new System.IO.StreamWriter(@"C:\Users\Serg\Desktop\key8.txt");
                        string[] mas = Cipher.key.Split('*');
                        for(int i = 0; i<4; i++)
                        {
                            while(mas[i].Length != 0)
                            {
                                r7.WriteLine(mas[i].Substring(0, 3));
                                mas[i].Remove(0, 3);
                            }
                            r7.WriteLine();
                        }
                        r7.Close();
                        break;
                    case 9:
                        break;
                    case 10:
                        System.IO.StreamWriter r10 = new System.IO.StreamWriter(@"C:\Users\Serg\Desktop\key11.txt");
                        r10.WriteLine(Cipher.key);
                        r10.Close();
                        break;
                }
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cipher = comboBox.SelectedIndex;
            codeCheck.Enabled = true;
            decodeCheck.Enabled = true;
            textBox.Text = Cipher.text;
        }

        private void doItButton_Click(object sender, EventArgs e)
        {
            Cipher.code = "";
            switch (cipher)
            {
                case 0:
                    textBox2.Text = Cipher.Caesar_Cipher(code_decode);
                    break;
                case 1:
                    textBox2.Text = Cipher.Substitution_Cipher(code_decode);
                    break;
                case 2:
                    textBox2.Text = Cipher.Fence_Cipher(code_decode);
                    break;
                case 3:
                    textBox2.Text = Cipher.RailFence_Cipher(code_decode);
                    break;
                case 4:
                    textBox2.Text = Cipher.Vigenere_Cipher(code_decode);
                    break;
                case 5:
                    textBox2.Text = Cipher.Autokey_Cipher(code_decode);
                    break;
                case 6:
                    textBox2.Text = Cipher.Polimorphic_Cipher(code_decode);
                    break;
                case 7:
                    textBox2.Text = Cipher.Bigram_Cipher(code_decode);
                    break;
                case 8:
                    textBox2.Text = Cipher.Matrix_Cipher(code_decode);
                    break;
                case 9:
                    textBox2.Text = Cipher.Cardani_Cipher(code_decode);
                    break;
                case 10:
                    textBox2.Text = Cipher.OneUse_Notebook_Cipher(code_decode);
                    break;
                case 11:
                    textBox2.Text = Cipher.ADFGWX_Cipher(code_decode);
                    break;
                case 12:
                    textBox2.Text = Cipher.RSA_Cipher(code_decode);
                    break;
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            Cipher.text = textBox.Text.ToUpper();
            comboBox.Enabled = true;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void keyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openKeyFileDialog.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(filePath != "")
            {
                using (StreamWriter writer = new StreamWriter(File.OpenWrite(filePath)))
                {
                    writer.WriteLine(Cipher.code != "" ? Cipher.code : Cipher.text);
                }
            }
            else
            {
                saveFileDialog.ShowDialog();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void saveKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (keyFilePath != "")
            {
                using (StreamWriter writer = new StreamWriter(File.OpenWrite(filePath)))
                {
                    if (Cipher.key != "")
                    {
                        writer.WriteLine(Cipher.key);
                    }
                    else
                    {
                        MessageBox.Show("Key value is empty!");
                    }
                }
            }
            else
            {
                saveKeyFileDialog.ShowDialog();
            }
        }
        private void openFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            filePath = openFileDialog.FileName;
            using (StreamReader reader = new StreamReader(openFileDialog.OpenFile()))
            {
                string text = reader.ReadToEnd();
                if (text == "")
                {
                    MessageBox.Show("File is empty!");
                    filePath = "";
                }
                else
                {
                    Cipher.text = text;
                    textBox.Text = text;
                    comboBox.Enabled = true;
                }
            }
        }

        private void openKeyFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            keyFilePath = openFileDialog.FileName;
            using (StreamReader reader = new StreamReader(openFileDialog.OpenFile()))
            {
                string text = reader.ReadToEnd();
                if (text == "")
                {
                    MessageBox.Show("Key-file is empty!");
                    keyFilePath = "";
                }
                else
                {
                    Cipher.key = text;
                    keyTextBox.Text = text;
                }
            }
        }

        private void saveFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(saveFileDialog.OpenFile()))
            {
                if(Cipher.text != "")
                {
                    writer.WriteLine(Cipher.text);
                }
                else
                {
                    MessageBox.Show("Nothing to save!");
                }
            }
        }

        private void saveKeyFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(saveKeyFileDialog.OpenFile()))
            {
                if (Cipher.text != "")
                {
                    writer.WriteLine(Cipher.key);
                }
                else
                {
                    MessageBox.Show("Nothing to save!");
                }
            }
        }
    }
}