using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher
{
    public static class Cipher
    {
        static string Sort(string k, int num)
        {
            string res = "";
            while (k.Length != 0)
            {
                int min = 88;
                int ind = 0;
                for (int i = 0; i < k.Length; i += 2)
                {
                    if (int.Parse(k.Substring(i, 2)[num].ToString()) < int.Parse((min + "")[num].ToString()))
                    {
                        ind = i;
                        min = int.Parse(k.Substring(i, 2));
                    }
                }
                res += min.ToString();
                k = k.Remove(ind, 2);
            }

            return res;
        }

        static void extended_euclid(long a, long b, out long x, out long y, out long d)
        {
            long q, r, x1, x2, y1, y2;

            if (b == 0)
            {

                d = a;
                x = 1;
                y = 0;

                return;
            }

            x2 = 1;
            x1 = 0;
            y2 = 0;
            y1 = 1;

            while (b > 0)
            {

                q = a / b;
                r = a - q * b;

                x = x2 - q * x1;
                y = y2 - q * y1;

                a = b;
                b = r;

                x2 = x1;
                x1 = x;
                y2 = y1;
                y1 = y;

            }

            d = a;
            x = x2;
            y = y2;

        }

        static long inverse(long a, long n)
        {

            long d, x, y;

            extended_euclid(a, n, out x, out y, out d);

            if (x < 0)
            {
                x += n;
            }

            if (d == 1) return x;

            return 0;

        }

        static long reverseNumber(long e, long p, long q)
        {
            return inverse(e, (p - 1) * (q - 1));
        }


        public static int N = 0;
        public static string text = "";
        public static string code = "";
        public static string key = "";
        const string alph = "ABCDEFGHIJKLMNOPQRSTUVWXYZ ";
        const string RSAAlph = "ABCDEFGHIJKLMNOPQRSTUVWXYZ 0123456789";
        static Random rnd = new Random();

        //++
        public static string Caesar_Cipher(bool cipher)
        {
            foreach (char c in text)
            {
                if (c != ' ' && (c > 'Z' || c < 'A'))
                {
                    text = text.Remove(text.IndexOf(c), 1);
                }
            }
            string kkey = key;
            foreach (char ch in kkey)
            {
                if (ch < '0' || ch > '9')
                {
                    kkey.Remove(key.IndexOf(ch), 1);
                }
            }
            if (kkey.Length == 0) throw new Exception("You have entered not a valid key. Your key: " + key);
            if (cipher)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    code += alph[(alph.IndexOf(text[i]) + int.Parse(key)) % 27];
                }
            }
            else
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (alph.IndexOf(text[i]) - int.Parse(key) < 0)
                    {
                        code += alph[(alph.IndexOf(text[i]) - int.Parse(key)) + 27];
                    }
                    else
                    {
                        code += alph[alph.IndexOf(text[i]) - int.Parse(key)];
                    }
                }
            }
            return code;
        }

        //++
        public static string Substitution_Cipher(bool cipher)
        {
            foreach (char c in text)
            {
                if (c != ' ' && (c > 'Z' || c < 'A'))
                {
                    text = text.Remove(text.IndexOf(c), 1);
                }
            }
            if (cipher)
            {
                foreach (char ch in text)
                {
                    code += key[alph.IndexOf(ch)];
                }
            }
            else
            {
                foreach (char ch in text)
                {
                    code += alph[key.IndexOf(ch)];
                }
            }
            return code;
        }

        //++
        public static string Fence_Cipher(bool cipher)
        {
            foreach (char c in text)
            {
                if (c != ' ' && (c > 'Z' || c < 'A'))
                {
                    text = text.Remove(text.IndexOf(c), 1);
                }
            }
            string k2key = key;
            foreach (char ch in k2key)
            {
                if (ch < '0' || ch > '9')
                {
                    k2key.Remove(key.IndexOf(ch), 1);
                }
            }
            if (k2key.Length == 0) throw new Exception("You have entered not a valid key. Your key: " + key);
            if (cipher)
            {
                for (int i = int.Parse(key) - 1; i >= 0; i--)
                {
                    for (int i2 = i; i2 < text.Length; i2 = i2 + int.Parse(key))
                    {
                        code += text[i2];
                    }
                }
            }
            else
            {
                int l = text.Length / int.Parse(key);
                int q = text.Length % int.Parse(key);
                string[] mas = new string[int.Parse(key)];
                if (q == 0)
                {
                    for (int i = 0; i < int.Parse(key); i++)
                    {
                        mas[i] = text.Substring(0, l);
                        text = text.Remove(0, l);
                    }
                }
                else
                {
                    for (int i = 0; i < int.Parse(key) - q; i++)
                    {
                        mas[i] = text.Substring(0, l);
                        text = text.Remove(0, l);
                    }

                    for (int i = int.Parse(key) - q; i < int.Parse(key); i++)
                    {
                        mas[i] = text.Substring(0, l + 1);
                        text = text.Remove(0, l + 1);
                    }
                }
                while (mas[int.Parse(key) - 1] != "")
                {
                    for (int i = int.Parse(key) - 1; i >= 0; i--)
                    {
                        if (mas[i] != "")
                        {
                            code += mas[i][0];
                            mas[i] = mas[i].Remove(0, 1);
                        }
                    }
                }
            }
            return code;
        }

        //++
        public static string RailFence_Cipher(bool cipher)
        {
            foreach (char c in text)
            {
                if (c != ' ' && (c > 'Z' || c < 'A'))
                {
                    text = text.Remove(text.IndexOf(c), 1);
                }
            }
            if (cipher)
            {
                for (int i = 0, i2 = 2 * (int.Parse(key) - 1), index = int.Parse(key) - 1; i2 >= 0; i += 2, i2 -= i, index--)
                {
                    code += text[index];
                    while (index < text.Length)
                    {
                        bool brk = false;
                        if ((i != 0) & (index + i < text.Length))
                        {
                            index += i;
                            code += text[index];
                        }
                        else
                        {
                            brk = true;
                        }
                        if ((i2 != 0) & (index + i2 < text.Length))
                        {
                            index += i2;
                            code += text[index];
                        }
                        else if (brk)
                        {
                            break;
                        }
                    }
                    index = int.Parse(key) - 1 - i / 2;
                }
                if (code.Length < text.Length)
                {
                    for (int i = 0; i < text.Length; i += 2 * (int.Parse(key) - 1))
                    {
                        code += text[i];
                    }
                }
            }
            else
            {
                int k = 1;
                int k2 = 1;
                string c = "";
                for (int i = 0; i < text.Length; i++, k += k2)
                {
                    if (k > int.Parse(key))
                    {
                        k2 = -1;
                        k -= 2;
                    }
                    if (k <= 0)
                    {
                        k2 = 1;
                        k += 2;
                    }
                    c += k + ".";
                }
                c = c.Substring(0, c.Length - 1);
                int ind = 0;
                string[] mas = c.Split('.');
                for (int i = int.Parse(key); i >= 0; i--)
                {
                    for (int i2 = 0; i2 < text.Length; i2++)
                    {
                        if (mas[i2] == i.ToString())
                        {
                            mas[i2] = text[ind++].ToString();
                        }
                    }
                }
                foreach (string str in mas)
                {
                    code += str;
                }
            }
            return code;
        }

        //++
        public static string Vigenere_Cipher(bool cipher)
        {
            foreach (char c in text)
            {
                if (c != ' ' && (c > 'Z' || c < 'A'))
                {
                    text = text.Remove(text.IndexOf(c), 1);
                }
            }
            if (cipher)
            {
                while (key.Length < text.Length)
                {
                    key += key;
                }
                key = key.Substring(0, text.Length);
                for (int i = 0; i < text.Length; i++)
                {
                    if (alph.IndexOf(text[i]) + alph.IndexOf(key[i]) >= 27)
                    {
                        code += alph[(alph.IndexOf(text[i]) + alph.IndexOf(key[i])) % 27];
                    }
                    else
                    {
                        code += alph[alph.IndexOf(text[i]) + alph.IndexOf(key[i])];
                    }
                }
            }
            else
            {
                while (key.Length < text.Length)
                {
                    key += key;
                }
                for (int i = 0; i < text.Length; i++)
                {
                    if ((alph.IndexOf(text[i]) - alph.IndexOf(key[i])) < 0)
                    {
                        code += alph[(alph.IndexOf(text[i]) - alph.IndexOf(key[i])) + 27];
                    }
                    else
                    {
                        code += alph[alph.IndexOf(text[i]) - alph.IndexOf(key[i])];
                    }
                }
                key = key.Substring(0, text.Length);
            }
            return code;
        }

        //++
        public static string Autokey_Cipher(bool cipher)
        {
            foreach (char c in text)
            {
                if (c != ' ' && (c > 'Z' || c < 'A'))
                {
                    text = text.Remove(text.IndexOf(c), 1);
                }
            }
            if (cipher)
            {
                while (key.Length < text.Length)
                {
                    key += text;
                }
                key = key.Substring(0, text.Length);
                for (int i = 0; i < text.Length; i++)
                {
                    code += alph[(alph.IndexOf(text[i]) + alph.IndexOf(key[i])) % 27];
                }
            }
            else
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if ((alph.IndexOf(text[i]) - alph.IndexOf(key[i])) < 0)
                    {
                        code += alph[(alph.IndexOf(text[i]) - alph.IndexOf(key[i])) + 27];
                        key += alph[(alph.IndexOf(text[i]) - alph.IndexOf(key[i])) + 27];
                    }
                    else
                    {
                        code += alph[alph.IndexOf(text[i]) - alph.IndexOf(key[i])];
                        key += alph[alph.IndexOf(text[i]) - alph.IndexOf(key[i])];
                    }
                }
            }
            return code;
        }

        //++
        public static string Polimorphic_Cipher(bool cipher)
        {
            key = key.Replace(" ", "");
            string[,] mass = new string[27, N];
            int indx = 0;
            foreach(string s in key.Split(';'))
            {
                int ind = 0;
                for(int i = 0; i <s.Length; i+=3)
                {
                    mass[indx, ind++] = s.Substring(i, 3);
                }
                indx++;
            } 
            if (cipher)
            {
                foreach (char c in text)
                {
                    if (c != ' ' && (c > 'Z' || c < 'A'))
                    {
                        text = text.Remove(text.IndexOf(c), 1);
                    }
                }
                foreach (char c in text)
                {
                    code += mass[alph.IndexOf(c),rnd.Next(0, N)];
                }
            }
            else
            {
                foreach (char c in text)
                {
                    if (c > '9' || c < '0')
                    {
                        text = text.Remove(text.IndexOf(c), 1);
                    }
                }
                while (text.Length != 0)
                {
                    for(int i = 0; i<27; i++)
                    {
                        for(int i2 = 0; i2 < N; i2++)
                        {
                            if(text.Length != 0 && text.Substring(0, 3) == mass[i,i2])
                            {
                                code += alph[i];
                                text = text.Remove(0, 3);
                                continue;
                            }
                        }
                    }
                }
            }
            return code;
        }

        //++
        public static string Bigram_Cipher(bool cipher)
        {
            foreach (char c in text)
            {
                if (c != ' ' && (c > 'Z' || c < 'A'))
                {
                    text = text.Remove(text.IndexOf(c), 1);
                }
            }
            string[] mass = key.Split('*');
            char[,] cm = new char[18, 6];

            for (int i2 = 0; i2 < 27; i2++)
            {
                cm[i2 / 3, i2 % 3] = mass[0][i2];
                cm[i2 / 3, (i2 % 3) + 3] = mass[1][i2];
                cm[(i2 / 3) + 9, i2 % 3] = mass[2][i2];
                cm[(i2 / 3) + 9, (i2 % 3) + 3] = mass[3][i2];
            }

            if (cipher)
            {
                if (text.Length % 2 != 0) text += " ";
                for(int i = 0; i<text.Length; i+=2)
                {
                    int index11 = -1;
                    int index12 = -1;
                    int index21 = -1;
                    int index22 = -1;
                    for (int p = 0; p < 9; p++)
                    {
                        for (int p2 = 0; p2 < 3; p2++)
                        {
                            if (cm[p, p2] == text[i])
                            {
                                index11 = p; index12 = p2;
                            }
                            else if (cm[p + 9, p2 + 3] == text[i+1])
                            {
                                index21 = p + 9; index22 = p2 + 3;
                            }
                        }
                    }
                    code += cm[index11, index22].ToString() + cm[index21, index12].ToString();
                }
            }
            else
            {
                for(int i = 0; i<text.Length; i+=2)
                {
                    int index11 = -1;
                    int index12 = -1;
                    int index21 = -1;
                    int index22 = -1;
                    for (int p = 0; p < 9; p++)
                    {
                        for (int p2 = 0; p2 < 3; p2++)
                        {
                            if (cm[p, p2 + 3] == text[i])
                            {
                                index11 = p; index12 = p2;
                            }
                            else if (cm[p + 9, p2] == text[i+1])
                            {
                                index21 = p; index22 = p2;
                            }
                        }
                    }
                    code += cm[index11, index22].ToString() + cm[index21 + 9, index12 + 3].ToString();
                }
            }
            return code;
        }

        //++
        public static string Matrix_Cipher(bool cipher)
        {
            foreach (char c in text)
            {
                if (c != ' ' && (c > 'Z' || c < 'A'))
                {
                    text = text.Remove(text.IndexOf(c), 1);
                }
            }
            string k3key = key;
            foreach (char ch in k3key)
            {
                if (ch<'0'||ch>'9')
                {
                    k3key.Remove(key.IndexOf(ch), 1);
                }
            }
            if (k3key.Length == 0) throw new Exception("You have entered not a valid key. Your key: " + key);
            int n = key.Length;
            int m = text.Length / n;
            if (text.Length % n != 0)
            {
                m++;
            }
            int indx = 0;
            char[,] masive = new char[m, n];
            if (cipher)
            {
                for (int tl = 0; tl < m; tl++)
                {
                    for (int kl = 0; kl < n; kl++)
                    {
                        if (indx < text.Length) masive[tl, kl] = text[indx++];
                        else masive[tl, kl] = '*';
                    }
                }
                int l = key.Length;
                while (key != "")
                {
                    int p = int.Parse(key.Substring(0, 1)) - 1;
                    key = key.Remove(0, 1);
                    for (int p2 = 0; p2 < m; p2++)
                    {
                        code += masive[p2, p];
                    }
                }
            }
            else
            {
                if (text.Length % key.Length != 0)
                {
                    int l = n;
                    while (key != "")
                    {
                        int p = int.Parse(key.Substring(0, 1));
                        key = key.Remove(0, 1);
                        if (p > text.Length % l)
                        {
                            for (int p2 = 0; p2 < text.Length / l; p2++)
                            {
                                if (indx < text.Length) masive[p2, p - 1] += text[indx++];
                            }
                        }
                        else
                        {
                            for (int p2 = 0; p2 < text.Length / l + 1; p2++)
                            {
                                if (indx < text.Length) masive[p2, p - 1] += text[indx++];
                            }
                        }
                    }
                    foreach (char ch in masive)
                    {
                        code += ch;
                    }
                }
                else
                {
                    while (key != "")
                    {
                        int p = int.Parse(key.Substring(0, 1)) - 1;
                        key = key.Remove(0, 1);
                        for (int p2 = 0; p2 < m; p2++)
                        {
                                if (indx < text.Length) masive[p2, p] += text[indx++];
                        }
                    }
                    foreach (char ch in masive)
                    {
                        code += ch;
                    }
                }
            }
            code = code.Replace("*", "");
            return code;
        }

        //++
        public static string Cardani_Cipher(bool cipher)
        {
            foreach (char c in text)
            {
                if (c != ' ' && (c > 'Z' || c < 'A'))
                {
                    text = text.Remove(text.IndexOf(c), 1);
                }
            }
            string k = key;
            string coordinates1 = "";
            string coordinates2 = "";
            string coordinates3 = "";
            string coordinates4 = "";

            coordinates1 = Sort(k, 0);
            coordinates1 = Sort(coordinates1, 1);
            k = "";
            for (int i = 0; i < key.Length; i += 2)
            {
                k += (int.Parse(key.Substring(i + 1, 1))).ToString() + (N - int.Parse(key.Substring(i, 1)) + 1).ToString();
            }
            coordinates2 = Sort(k, 0);
            coordinates2 = Sort(coordinates2, 1);
            k = "";
            for (int i = 0; i < key.Length; i += 2)
            {
                k += (N - int.Parse(key.Substring(i, 1)) + 1).ToString() + (N - int.Parse(key.Substring(i + 1, 1)) + 1).ToString();
            }

            coordinates3 = Sort(k, 0);
            coordinates3 = Sort(coordinates3, 1);
            k = "";
            for (int i = 0; i < key.Length; i += 2)
            {
                k += (N - int.Parse(key.Substring(i + 1, 1)) + 1).ToString() + (int.Parse(key.Substring(i, 1))).ToString();
            }

            coordinates4 = Sort(k, 0);
            coordinates4 = Sort(coordinates4, 1);

            if (cipher)
            {
                char[,] txt = new char[N, N];
                int ind = 0;
                for (int i = 0; i < N; i++)
                {
                    for (int i2 = 0; i2 < N; i2++)
                    {
                        if (ind < text.Length)
                        {
                            txt[i, i2] = text[ind++];
                        }
                        else
                        {
                            txt[i, i2] = '*';
                        }
                    }
                }
                for (int i = 0; i<coordinates1.Length; i+=2)
                {
                    int indx = int.Parse(coordinates1.Substring(i, 2));
                    code += txt[(indx / 10) - 1, (indx % 10) - 1];
                    txt[(indx / 10) - 1, (indx % 10) - 1] = '*';
                }
                for (int i = 0; i < coordinates2.Length; i += 2)
                {
                    int indx = int.Parse(coordinates2.Substring(i, 2));
                    code += txt[(indx / 10) - 1, (indx % 10) - 1];
                    txt[(indx / 10) - 1, (indx % 10) - 1] = '*';
                }
                for (int i = 0; i < coordinates3.Length; i += 2)
                {
                    int indx = int.Parse(coordinates3.Substring(i, 2));
                    code += txt[(indx / 10) - 1, (indx % 10) - 1];
                    txt[(indx / 10) - 1, (indx % 10) - 1] = '*';
                }
                for (int i = 0; i < coordinates4.Length; i += 2)
                {
                    int indx = int.Parse(coordinates4.Substring(i, 2));
                    code += txt[(indx / 10) - 1, (indx % 10) - 1];
                    txt[(indx / 10) - 1, (indx % 10) - 1] = '*';
                }
            }
            else
            {
                char[,] txt = new char[N, N];
                int idx = 0;
                int idx2 = 0;
                while(idx < text.Length)
                {
                    if(idx2%10 < N)
                    {
                        txt[idx2 / 10, idx2 % 10] = '*';
                        idx++;
                        idx2++;
                    }
                    else
                    {
                        idx2 = (idx2 / 10 + 1) * 10;
                    }
                }
                for (int i = 0; i < coordinates1.Length; i += 2)
                {
                    int indx = int.Parse(coordinates1.Substring(i, 2));
                    if (text.Length != 0)
                    {
                        if (txt[(indx / 10) - 1, (indx % 10) - 1] == '*')
                        {
                            txt[(indx / 10) - 1, (indx % 10) - 1] = text[0];
                            text = text.Remove(0, 1);
                        }
                    }
                    else txt[(indx / 10) - 1, (indx % 10) - 1] = '?';
                }
                for (int i = 0; i < coordinates2.Length; i += 2)
                {
                    int indx = int.Parse(coordinates2.Substring(i, 2));
                    if (text.Length != 0)
                    {
                        if (txt[(indx / 10) - 1, (indx % 10) - 1] == '*')
                        {
                            txt[(indx / 10) - 1, (indx % 10) - 1] = text[0];
                            text = text.Remove(0, 1);
                        }
                    }
                    else txt[(indx / 10) - 1, (indx % 10) - 1] = '?';
                }
                for (int i = 0; i < coordinates3.Length; i += 2)
                {
                    int indx = int.Parse(coordinates3.Substring(i, 2));
                    if (text.Length != 0)
                    {
                        if (txt[(indx / 10) - 1, (indx % 10) - 1] == '*')
                        {
                            txt[(indx / 10) - 1, (indx % 10) - 1] = text[0];
                            text = text.Remove(0, 1);
                        }
                    }
                    else txt[(indx / 10) - 1, (indx % 10) - 1] = '?';
                }
                for (int i = 0; i < coordinates4.Length; i += 2)
                {
                    int indx = int.Parse(coordinates4.Substring(i, 2));
                    if (text.Length != 0)
                    {
                        if (txt[(indx / 10) - 1, (indx % 10) - 1] == '*')
                        {
                            txt[(indx / 10) - 1, (indx % 10) - 1] = text[0];
                            text = text.Remove(0, 1);
                        }
                    }
                    else txt[(indx / 10) - 1, (indx % 10) - 1] = '?';
                }
                foreach(char c in txt)
                {
                    code += c.ToString();
                }
            }
            return code.Replace("*", "");
        }

        //++
        public static string OneUse_Notebook_Cipher(bool cipher)
        {
            foreach(char c in key)
            {
                if (c < '0' || c > '1')
                {
                    throw new Exception("You have entered invalid code.");
                }
            }
            string text2 = "";
            if (cipher)
            {
                foreach (char ch in text)
                {
                    switch (ch)
                    {
                        case 'A':
                            text2 += "00000";
                            break;
                        case 'B':
                            text2 += "00001";
                            break;
                        case 'C':
                            text2 += "00010";
                            break;
                        case 'D':
                            text2 += "00011";
                            break;
                        case 'E':
                            text2 += "00100";
                            break;
                        case 'F':
                            text2 += "00101";
                            break;
                        case 'G':
                            text2 += "00110";
                            break;
                        case 'H':
                            text2 += "00111";
                            break;
                        case 'I':
                            text2 += "01000";
                            break;
                        case 'J':
                            text2 += "01001";
                            break;
                        case 'K':
                            text2 += "01010";
                            break;
                        case 'L':
                            text2 += "01011";
                            break;
                        case 'M':
                            text2 += "01100";
                            break;
                        case 'N':
                            text2 += "01101";
                            break;
                        case 'O':
                            text2 += "01110";
                            break;
                        case 'P':
                            text2 += "01111";
                            break;
                        case 'Q':
                            text2 += "10000";
                            break;
                        case 'R':
                            text2 += "10001";
                            break;
                        case 'S':
                            text2 += "10010";
                            break;
                        case 'T':
                            text2 += "10011";
                            break;
                        case 'U':
                            text2 += "10100";
                            break;
                        case 'V':
                            text2 += "10101";
                            break;
                        case 'W':
                            text2 += "10110";
                            break;
                        case 'X':
                            text2 += "10111";
                            break;
                        case 'Y':
                            text2 += "11000";
                            break;
                        case 'Z':
                            text2 += "11001";
                            break;
                        case ' ':
                            text2 += "11010";
                            break;
                    }
                }
                for (int j3 = 0; j3 < text2.Length; j3++)
                {
                    if (text2[j3] != key[j3])
                    {
                        code += "1";
                    }
                    else if (text2[j3] == key[j3])
                    {
                        code += "0";
                    }
                }
            }
            else
            {
                foreach (char c in text)
                {
                    if (c > '9' || c < '0')
                    {
                        text = text.Remove(text.IndexOf(c), 1);
                    }
                }
                string cd = "";
                for (int j3 = 0; j3 < text.Length; j3++)
                {
                    if (text[j3] != key[j3])
                    {
                        cd += "1";
                    }
                    else if (text[j3] == key[j3])
                    {
                        cd += "0";
                    }
                }
                for (int j3 = 0; j3 < cd.Length; j3 += 5)
                {
                    switch (cd.Substring(j3, 5))
                    {
                        case "00000":
                            code += "A";
                            break;
                        case "00001":
                            code += "B";
                            break;
                        case "00010":
                            code += "C";
                            break;
                        case "00011":
                            code += "D";
                            break;
                        case "00100":
                            code += "E";
                            break;
                        case "00101":
                            code += "F";
                            break;
                        case "00110":
                            code += "G";
                            break;
                        case "00111":
                            code += "H";
                            break;
                        case "01000":
                            code += "I";
                            break;
                        case "01001":
                            code += "J";
                            break;
                        case "01010":
                            code += "K";
                            break;
                        case "01011":
                            code += "L";
                            break;
                        case "01100":
                            code += "M";
                            break;
                        case "01101":
                            code += "N";
                            break;
                        case "01110":
                            code += "O";
                            break;
                        case "01111":
                            code += "P";
                            break;
                        case "10000":
                            code += "Q";
                            break;
                        case "10001":
                            code += "R";
                            break;
                        case "10010":
                            code += "S";
                            break;
                        case "10011":
                            code += "T";
                            break;
                        case "10100":
                            code += "U";
                            break;
                        case "10101":
                            code += "V";
                            break;
                        case "10110":
                            code += "W";
                            break;
                        case "10111":
                            code += "X";
                            break;
                        case "11000":
                            code += "Y";
                            break;
                        case "11001":
                            code += "Z";
                            break;
                        case "11010":
                            code += " ";
                            break;
                    }
                }
            }
            return code;
        }

        //++
        public static string ADFGWX_Cipher(bool cipher)
        {
            foreach (char c in text)
            {
                if (c != ' ' && (c > 'Z' || c < 'A') && (c > '9' || c < '0'))
                {
                    text = text.Remove(text.IndexOf(c), 1);
                }
            }
            const string letters = "ADFGWX";
            string cd = "";
            char[,] box = new char[6, 6];
            int ind = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    box[i, i2] = key[ind++];
                }
            }
            key = key.Split('*')[1];

            if (cipher)
            {
                while (text.Length != 0)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        for (int i2 = 0; i2 < 6; i2++)
                        {
                            if (text.Length!= 0 && box[i, i2] == text[0])
                            {
                                code += letters[i].ToString() + letters[i2].ToString();
                                text = text.Remove(0, 1);
                            }
                        }
                    }
                }
                text = code;
                code = ""; code = Matrix_Cipher(true);
            }
            else
            {
                cd = Matrix_Cipher(false);
                code = "";
                for(int i = 0; i<cd.Length; i+=2)
                {
                    code += box[letters.IndexOf(cd[i]), letters.IndexOf(cd[i + 1])];
                }
            }
            return code.Replace("*","");
        }

        public static string RSA_Cipher(bool cipher)
        {
            long e = long.Parse(key.Split(' ')[0]), n = long.Parse(key.Split(' ')[1]), p = long.Parse(key.Split(' ')[2]), q = long.Parse(key.Split(' ')[3]);
            if (cipher)
            {
                string cryptotext = "";
                if (text.Length % 2 != 0) text += " ";
                int[] blocks = new int[text.Length / 2];
                for (int i = 0; i < text.Length; i += 2)
                {
                    blocks[i / 2] = RSAAlph.IndexOf(text[i]) * 100 + RSAAlph.IndexOf(text[i + 1]);
                }
                string crpttxt = "";
                foreach (int i in blocks)
                {
                    if (i >= 1000) crpttxt += i;
                    else if (i >= 100) crpttxt += "0" + i;
                    else if (i >= 10) crpttxt += "00" + i;
                    else crpttxt += "000" + i;
                }
                foreach (int i in blocks)
                {
                    long v = i;
                    for (long c = 1; c < e; c++)
                    {
                        v *= i;
                        v %= n;
                    }
                    if (v >= 1000) cryptotext += v;
                    else if (v >= 100) cryptotext += "0" + v;
                    else if (v >= 10) cryptotext += "00" + v;
                    else cryptotext += "000" + v;
                }
                return cryptotext;
            }
            else
            {
                string message = "";
                int[] blocks = new int[text.Length / 5];
                for (int i = 0; i < text.Length; i += 5)
                {
                    blocks[i / 5] = int.Parse(text.Substring(i, 5));
                }
                long c2 = reverseNumber(e, p, q);
                foreach (int i in blocks)
                {
                    long v = i;
                    for (long c = 1; c < c2; c++)
                    {
                        v *= i;
                        v %= p * q;
                    }
                    message += RSAAlph[(int)v / 100] + "" + RSAAlph[(int)v % 100];
                }
                return message;
            }
        }
    }
}
