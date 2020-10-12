using System;
using System.IO;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            
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