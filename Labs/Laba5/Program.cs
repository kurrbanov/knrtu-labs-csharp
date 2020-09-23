using System;

namespace laba5
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void Task1()
        {
            string[] s = Console.ReadLine().Split();
            
            Array.Reverse(s);

            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i] + " ");
            }
            Console.WriteLine();
            
            Array.Reverse(s);

            for (int i = s.Length - 1; i >= 0; i--)
            {
                char[] c = s[i].ToCharArray();
                for (int j = c.Length - 1; j >= 0; j--)
                {
                    Console.Write(c[j]);
                }
                Console.Write(" ");
            }
        }

        static void Task2()
        {
            string[] s = new string[1];
            string str = "";

            int lol = 1;
            while (true)
            {
                char c = Convert.ToChar(Console.ReadKey().KeyChar);

                if (c == '.')
                {
                    Array.Resize(ref s, lol);
                    s[lol - 1] = str; 
                    lol++;
                    break;
                }

                if (c == ' ')
                {
                    Array.Resize(ref s, lol);
                    s[lol - 1] = str; 
                    lol++;
                    str = "";
                }
                else
                {
                    str += Convert.ToString(c);
                }
            }

            int sizeArr = s.Length;
            int k = 0;
            
            for (int i = 0; i < sizeArr; i++) k = k < s[i].Length ? s[i].Length : k;
            
            char[] alphabet = new char[] {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
            string[] res = new string[sizeArr];

            int kq = 0;
            foreach (var i in s)
            {
                char[] c = i.ToCharArray();
                string suka = "";
                for (int j = 0; j < c.Length; j++)
                {
                    for (int p = 0; p < alphabet.Length; p++)
                        if (alphabet[p] == c[j])
                        {
                            c[j] = alphabet[(p + k) % alphabet.Length];
                            break;
                        }
                    suka += Convert.ToString(c[j]);
                }
                
                res[kq] = suka;
                kq++;
            }
        
            Console.WriteLine();
            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i] + " ");
            }
            Console.WriteLine();
        }
        //2 variant
        public static void Task1_2()
        {
            char[] inp = Console.ReadLine().ToCharArray();
            char t;
            int l = inp.Length;
            for (int i = 0; i < l / 2; i++)
            {
                t = inp[i];
                inp[i] = inp[l - i - 1];
                inp[l - i - 1] = t;
            }
            string outp = new string(inp);
            Console.WriteLine(outp);
        }
        public static void Task2_2()
        {
            string inp = Console.ReadLine();
            string[] words = inp.Split(' ');
            int max = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (ValidateString(words[i]))
                {
                    max = words[i].Length > max ? words[i].Length : max;
                }
                else
                {
                    max = (words[i].Length - 1) > max ? words[i].Length - 1: max;
                }
            }

            int k = 0;
            
            foreach (string str in words)
            {
                words[k] = enc(str, max);
                k += 1;
            }
            string output = words[0];
            for (int i = 1; i < words.Length; i++)
            {
                output = string.Concat(output, " ", words[i]);
            }

            Console.WriteLine(output + " " + max);
        }
        static string enc(String a, int b){
            int l = a.Length;
            char[] j = a.ToCharArray();
            for (int i = 0; i < l; i++) {
                char g = a[i];
                if (System.Char.IsLetter(g)) 
                {
                    if (System.Char.IsUpper(g)) 
                    {
                        if (g + b <= 90){
                            int c = (int) g + b;
                            char d = (char) c;
                            j[i] = d;
                        }
                        else 
                        {
                            int c = (int) g + b;
                            int v = c - 26;
                            char d = (char) v;
                            j[i] = d;
                        }
                    }
                    else {
                        if (g + b <= 122)
                        {
                            int c = (int) g + b;
                            char d = (char) c;
                            j[i] = d;
                        }
                        else
                        {
                            int c = (int) g + b;
                            int v = c - 26;
                            char d = (char) v;
                            j[i] = d;
                        }
                    }
                }
            }
            return new string(j);
        }
        public static bool ValidateString(string str) {
            str = str.ToLower();
            char[] charArray = str.ToCharArray();
            for (int i = 0; i < charArray.Length; i++) 
            {
                char ch = charArray[i];
                if (!(ch >= 'a' && ch <= 'z')) {
                    return false;
                }
            }
            return true;
        }
    }
}
