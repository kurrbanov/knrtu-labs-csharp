using System;

namespace laba3
{
    class Program
    {
        static void Main(string[] args)
        {
            Task3_8();
        }
        static void Task1_2()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double[] arr = new double[n];
            double sum = 0;
            int fir = 0;
            int last = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 1; i < arr.Length - 1; i += 2)
            {
                sum += arr[i];
            }
            Console.WriteLine("Сумма элементов с нечётными номерами: " + sum);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    fir = i;
                    break;
                } 
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    last = i;
                }
            }
            sum = 0;
            for (int i = fir; i <= last; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Сумма элементов между первым отрицательным и последним отрицательным: " + sum);
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void Task1_8()
        {
            // 8 variant
            int c, n, ans = 0;
            n = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            double[] arr = new Double[n];
            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
                arr[i] = Convert.ToDouble(s[i]);

            for (int i = 0; i < n; i++)
                if (arr[i] < c)
                    ans++;

            int lastIdx = 0;
            int sumArr = 0;

            for (int i = 0; i < n; i++)
                if (arr[i] < 0) lastIdx = i;

            for (int i = lastIdx + 1; i < n; i++)
                sumArr += Convert.ToInt32(arr[i]);

            Console.WriteLine(ans);
            Console.WriteLine(sumArr);
        }
        
        static void Task2_2()
        {
            int m;
            m = Convert.ToInt32(Console.ReadLine());
            int[,] arra = new int[m, m];
            for(int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arra[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int mul;
            bool meow = true;
            for (int i = 0; i < m; i++)
            {
                mul = arra[i, 0];
                for (int j = 0; j < m; j++)
                {
                    if (arra[i, j] > 0)
                    {
                        mul *= arra[i, j];
                    }
                    else
                    {
                        meow = false;
                        break;
                    }
                }
                if (meow == true) 
                {
                    Console.WriteLine(mul);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arra[i, j] + " ");
                }
                Console.WriteLine();
            }
            int t = 0;
            for (int i = 0; i < n; i++)
            {
                t = arra[i, 0];
                arra[i, 0] = arra[i, 1];
                arra[i, 1] = t;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arra[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Task2_8()
        {
            // variant 8
            int n;
            n = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[n, n]; // matrix
            
            // read matrix
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                    arr[i, j] = Convert.ToInt32(s[j]);
            }

            for (int i = 0; i < n; i++)
            {
                int sumArr = 0;
                bool flag = true;

                for (int j = 0; j < n; j++)
                {
                    if (arr[j, i] > 0) sumArr += arr[j, i];
                    else
                    {
                        flag = false; break;
                    } 
                }
                
                if (flag) Console.WriteLine($"Sum of + {i} row: {sumArr}");
            }

            Console.WriteLine();
            
            Console.WriteLine("Matrix: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
            Console.WriteLine("Matrix change: ");
            for (int i = 0; i < n; i++)
            {
                int temp = arr[i, n - 2];
                arr[i, n - 2] = arr[i, n - 1];
                arr[i, n - 1] = temp;
            }
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void Task3_8()
        {
            // variant 8
            int[][] arr = new int[5][];

            arr[0] = new int[5];
            arr[1] = new int[3];
            arr[2] = new int[8];
            arr[3] = new int[4];
            arr[4] = new int[6];

            for (int i = 0; i < 5; i++)
            {
                Random rand = new Random(); // class Random 
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rand.Next(-500, 500);
                }
            }

            for (int i = 0; i < 5; i++)
            {
                int sumArr = 0;
                for (int j = 0; j < arr[i].Length; j++)
                {
                    sumArr += arr[i][j];
                }
                Console.WriteLine($"sum row {i} : {sumArr}");
            }

            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]);
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
    }
}
