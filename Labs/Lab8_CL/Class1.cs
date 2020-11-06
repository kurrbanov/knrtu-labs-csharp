using System;

namespace Lab8_CL
{
    public static class Class1
    {
        
        // filling the ..................................
        
        // int array
        public static void fillArr(int l, int r, int[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(l, r);
            }
        }
        
        // two-dimensional int array
        public static void fillArr(int l, int r, int[,] arr)
        {
            int row = arr.GetUpperBound(0) + 1;
            int column = arr.Length / row;

            for (int i = 0; i < row; i++)
            {
                Random rand = new Random();
                for (int j = 0; j < column; j++)
                {
                    arr[i, j] = rand.Next(l, r);
                }
            }
        }
        
        
        // double array
        public static void fillArr(double[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.NextDouble();
            }
        }
        
        // two-dimensional double array
        public static void fillArr(double[,] arr)
        {
            int row = arr.GetUpperBound(0) + 1;
            int column = arr.Length / row;

            for (int i = 0; i < row; i++)
            {
                Random rand = new Random();
                for (int j = 0; j < column; j++)
                {
                    arr[i, j] = rand.NextDouble();
                }
            }
        }
        
        
        
        // Sum of ..............................
        
        // int array
        public static int sumArr(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }
        
        // two-dimensional int array
        public static int sumArr(int[,] arr)
        {
            int sum = 0;
            
            foreach (var i in arr)
            {
                sum += i;
            }

            return sum;
        }
        
        
        // double array
        public static double sumArr(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }
        
        // two-dimensional double array
        public static double sumArr(double[,] arr)
        {
            double sum = 0;
            foreach (var i in arr)
            {
                sum += i;
            }

            return sum;
        }
        
        
        
        // Multiplication of .............................
                
        // int array
        public static int prArr(int[] arr)
        {
            int mult = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                mult *= arr[i];
            }

            return mult;
        }
        
        // two-dimensional int array
        public static int prArr(int[,] arr)
        {
            int mult = 1;
            foreach (var i in arr)
            {
                mult *= i;
            }

            return mult;
        }


        // double array
        public static double prArr(double[] arr)
        {
            double mult = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                mult *= arr[i];
            }

            return mult;
        }
        
        // two-dimensional double array
        public static double prArr(double[,] arr)
        {
            double mult = 1.0;
            foreach (var i in arr) mult *= i;

            return mult;
        }
        
        
        
        // Max element and index of .............................
        
        // int array
        public static int[] max(ref int[] a)
        {
            int[] mxElIdx = new int[2];
            for (int i = 0; i < a.Length; i++)
            {
                if (mxElIdx[0] < a[i])
                {
                    mxElIdx[0] = a[i];
                    mxElIdx[1] = i;
                }
            }

            return mxElIdx;
        }

        // two-dimensional int array
        public static int[] max(ref int[,] a)
        {
            int[] mxElIdx = new int[3];
            int row = a.GetUpperBound(0) + 1;
            int column = a.Length / row;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (mxElIdx[0] < a[i, j])
                    {
                        mxElIdx[0] = a[i, j];
                        mxElIdx[1] = i;
                        mxElIdx[2] = j;
                    }
                }
            }

            return mxElIdx;
        }
        
        
        // double array
        public static double[] max(ref double[] a)
        {
            double[] mxElIdx = new double[2];
            for (int i = 0; i < a.Length; i++)
            {
                if (mxElIdx[0] < a[i])
                {
                    mxElIdx[0] = a[i];
                    mxElIdx[1] = i;
                }
            }

            return mxElIdx;
        }
        
        // two-dimensional double array
        public static double[] max(ref double[,] a)
        {
            double[] mxElIdx = new Double[3];
            int row = a.GetUpperBound(0) + 1;
            int column = a.Length / row;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (mxElIdx[0] < a[i, j])
                    {
                        mxElIdx[0] = a[i, j];
                        mxElIdx[1] = i;
                        mxElIdx[2] = j;
                    }
                }
            }

            return mxElIdx;
        }
        
        
        // string array
        public static int[] max(ref string[] str)
        {
            int[] mxElIdx = new int[2];
            for (int i = 0; i < str.Length; i++)
            {
                if (mxElIdx[0] < str[i].Length)
                {
                    mxElIdx[0] = str[i].Length;
                    mxElIdx[1] = i;
                }
            }

            return mxElIdx;
        }
        
        // two-dimensional string array
        public static int[] max(ref string[,] str)
        {
            int[] mxElIdx = new int[3];
            for (int i = 0; i < str.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < (str.Length / (str.GetUpperBound(0) + 1)); j++)
                {
                    if (mxElIdx[0] < str[i, j].Length)
                    {
                        mxElIdx[0] = str[i, j].Length;
                        mxElIdx[1] = i;
                        mxElIdx[2] = j;
                    }
                }
            }

            return mxElIdx;
        }

        
        
        // Output of .......................

        // int array
        public static string printArr(int[] arr)
        {
            string res = ""; 
            foreach (var i in arr)
            {
                res += Convert.ToString(i) + " ";
            }

            return res;
        }

        // two-dimensional int array
        public static string printArr(int[,] arr)
        {
            string res = "";
            int x = arr.GetUpperBound(0) + 1;
            int y = arr.Length / x;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    res += Convert.ToString(arr[i, j]) + " ";
                }

                res += "\n";
            }

            return res;
        }

        
        // double array
        public static void printDoub(double[] arr)
        {
            foreach (var i in arr)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        
        // two-dimensional double array
        public static void printDoub(double[,] arr)
        {
            int x = arr.GetUpperBound(0) + 1;
            int y = arr.Length / x;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        
        
        // string array
        public static void printStr(string[] s)
        {
            foreach (var i in s) Console.Write($"{i} ");
            Console.WriteLine();
        }
        
        // two-dimensional string array
        public static void printStr(string[,] s)
        {
            int x = s.GetUpperBound(0) + 1;
            int y = s.Length / x;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write($"{s[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}