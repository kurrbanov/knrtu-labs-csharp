using System;
using System.IO;
using System.Collections.Generic;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        
        
        
        static void Task1_8()
        {
            string source = @"C:\Users\user\RiderProjects\learnpr1\input.txt";
            string text = "";
            
            using (FileStream file = new FileStream(source, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    text = sr.ReadToEnd();
                }
            }
            
            string[] s = text.Split('\n', ' ', '\r');

            int maxLen = 0, count = 0;
            string word = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (maxLen < s[i].Length)
                {
                    maxLen = s[i].Length;
                    word = s[i];
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == word) count++;
            }
            
            Console.WriteLine($"Count of '{word}' is {count}");
        }


        
        
        static void Task2_8()
        {
            string input = @"C:\Users\user\RiderProjects\learnpr1\input.txt";

            Dictionary<string, List<string>> sports = new Dictionary<string, List<string>>();

            using (FileStream fs = new FileStream(input, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] s = line.Split(); // s[0] - club, s[1] - sport, s[2] - address;

                        if (sports.ContainsKey(s[1]))
                        {
                            string toAdd = s[0] + " - ";
                            for (int i = 2; i < s.Length; i++) toAdd += s[i];
                            sports[s[1]].Add(toAdd);
                        }
                        else
                        {
                            string toAdd = s[0] + " - ";
                            for (int i = 2; i < s.Length; i++) toAdd += s[i];
                            sports[s[1]] = new List<string> {toAdd};
                        }
                    }
                }
            }

            foreach (KeyValuePair<string, List<string>> keyValue in sports)
            {
                Console.WriteLine($"{keyValue.Key}: ");
                string[] str = keyValue.Value.ToArray();
                foreach (var q in str)
                {
                    Console.WriteLine(q);
                }
                Console.WriteLine();
            }
        }

        
        
        static void Task2_9()
        {
            string input = @"C:\Users\user\RiderProjects\learnpr1\input.txt"; // путь к файлу.

            
            int k = 0; // количество предложений 
            string[] sentences = new string[100];

            using (FileStream fs = new FileStream(input, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        sentences[k] = line;
                        k++;
                    }
                }
            }

            int[,] a = new int[8, 100];
            int[] kolvoSents = new int[8];

            // 0 - a, 1 - в, 2 - е, 3 - и, 4 - о, 5 - у, 6 - э, 7 - я

            for (int i = 0; i < k; i++)
            {
                if (sentences[i][0] == 'А' && sentences[i][1] == ' ')
                {
                    a[0, kolvoSents[0]] = i + 1;
                    kolvoSents[0]++;
                }
                else if (sentences[i][0] == 'В' && sentences[i][1] == ' ')
                {
                    a[1, kolvoSents[1]] = i + 1;
                    kolvoSents[1]++;
                }
                else if (sentences[i][0] == 'Е' && sentences[i][1] == ' ')
                {
                    a[2, kolvoSents[2]] = i + 1;
                    kolvoSents[2]++;
                }
                else if (sentences[i][0] == 'И' && sentences[i][1] == ' ')
                {
                    a[3, kolvoSents[3]] = i + 1;
                    kolvoSents[3]++;
                }
                else if (sentences[i][0] == 'О' && sentences[i][1] == ' ')
                {
                    a[4, kolvoSents[4]] = i + 1;
                    kolvoSents[4]++;
                }
                else if (sentences[i][0] == 'У' && sentences[i][1] == ' ')
                {
                    a[5, kolvoSents[5]] = i + 1;
                    kolvoSents[5]++;
                }
                else if (sentences[i][0] == 'Э' && sentences[i][1] == ' ')
                {
                    a[6, kolvoSents[6]] = i + 1;
                    kolvoSents[6]++;
                }
                else if (sentences[i][0] == 'Я' && sentences[i][1] == ' ')
                {
                    a[7, kolvoSents[7]] = i + 1;
                    kolvoSents[7]++;
                }
            }

            int[] wasSentence = new int[k];
            
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < kolvoSents[i]; j++)
                {
                    Console.WriteLine(a[i, j]);
                    wasSentence[j] = 1;
                }
            }

            for (int i = 0; i < k; i++)
            {
                if (wasSentence[i] != 1)
                {
                    Console.WriteLine(i + 1);
                }
            }
        }

    }
}