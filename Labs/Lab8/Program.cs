using System;
using static Lab8_CL.Class1;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3,2];
            fillArr(-10, 10, arr);

            Console.WriteLine(sumArr(arr));
            Console.WriteLine(prArr(arr));
            int[] resMax = max(ref arr);
            Console.WriteLine($"{resMax[0]} {resMax[1]} {resMax[2]}");
            Console.WriteLine(printArr(arr));
        }
    }
}