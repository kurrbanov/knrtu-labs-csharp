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
    }
}