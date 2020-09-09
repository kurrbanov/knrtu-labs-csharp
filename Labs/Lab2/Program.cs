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

        static void Task1()
        {
            // 8 variant
            static void Task1()
            {
                double dx = Convert.ToDouble(Console.ReadLine());
            
                double x = -9;

                while (x <= 7)
                {
                    if (x >= -9 && x <= -7)
                    {
                        Console.Write("y " + Convert.ToString(x) + ": ");
                        Console.WriteLine(0);
                    } else if (x > -7 && x <= -3)
                    {
                        Console.Write("y " + Convert.ToString(x) + ": ");
                        Console.WriteLine(x + 7);
                    } else if (x >= -2 && x <= 2)
                    {
                        Console.Write("y " + Convert.ToString(x) + ": ");
                        Console.WriteLine(x * x);
                    } else if (x >= 2 && x <= 4)
                    {
                        Console.Write("y " + Convert.ToString(x) + ": ");
                        Console.WriteLine(-2 * x + 8);
                    } else if (x >= 4 && x <= 7)
                    {
                        Console.Write("y " + Convert.ToString(x) + ": ");
                        Console.WriteLine(0);
                    }
                    x += dx;
                }

            }
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
            
            // variant 3  DON'T touch them please.
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                long lenNum = Convert.ToString(i).Length;
                long check = (i * i) - i;

                if (check % Convert.ToInt64(Pow(10, lenNum)) == 0)
                    Console.WriteLine(i);
            }
            
            // variant 4, 5 - very easy
            
            // variant 6
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    int num = Convert.ToInt32("42" + Convert.ToString(i) + Convert.ToString(j) + "4");
                    
                    if (num % 72 == 0) Console.WriteLine(num);
                }

            // variant 7, 9 - easy
            
            // variant 8
            for (int i = 100; i <= 999; i++)
            {
                if (i % 11 == 0 && (i % 10 == 3 || i / 100 == 3 || (i / 10) % 10 == 3)) Console.WriteLine(i);
            }
            
            //variant 10
            for (int i = 100; i < 1000; i++)
            {
                if (i % 3 == 0)
                {
                    int sumNum = i % 10 + i / 100 + ((i / 10) % 10);

                    if (sumNum > sumNum / 3.0) Console.WriteLine(i);
                }
            }
        }
    }
}