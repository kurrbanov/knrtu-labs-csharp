using System;
using static System.Math;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task2();
        }

        static void Task2()
        {
            // variant 1
            for (int i = 10; i <= 99; i++)
            {
                int SumOfNum1 = i % 10 + i / 10;
                int num2 = i * 2;
                int SumOfNum2 = 0;

                while (num2 > 0)
                {
                    SumOfNum2 += num2 % 10;
                    num2 /= 10;
                }
                
                if (SumOfNum1 == SumOfNum2)
                {
                    Console.Write(i);
                    Console.Write(" ");
                    Console.WriteLine(i * 2);
                }
            }
            
            // variant 2
            for (int i = 10; i <= 99; i++)
            {
                int num = i * i;

                if (i < 32 && num / 100 == num % 10)
                    Console.WriteLine(i);
                else if (i >= 32 && num / 1000 == num % 10 && (num / 100) % 10 == (num % 100) / 10)
                    Console.WriteLine(i);
            }
            
            // variant 3 
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                long lenNum = Convert.ToString(i).Length;
                long check = (i * i) - i;

                if (check % Convert.ToInt64(Pow(10, lenNum)) == 0)
                    Console.WriteLine(i);
            }
        }
    }
}