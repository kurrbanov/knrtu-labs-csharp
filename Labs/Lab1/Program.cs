using System;
using static System.Math;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        
        /// /////////////////////////////////////////////////////////////////
        /// // First Task
        /// /////////////////////////////////////////////////////////////////
        
        static void Task1()
        {
            double a = Convert.ToDouble(Console.ReadLine());
         
            // 1 variant
            double z1 = Cos(a) + Sin(a) + Cos(3 * a) + Sin(3 * a);
            double z2 = (double) 1 / 4 - (double) 1 / 4 * Sin((double) 5 / 2 * PI - 8 * a);

            Console.WriteLine(Round(z1, 3)); 
            Console.WriteLine(Round(z2, 3));
            
            // 5 variant
            z1 = 1.0 - (double) 1 / 4 * (Sin(2 * a) * Sin(2 * a)) + Cos(2 * a);
            z2 = Cos(a) * Cos(a) + Pow(Cos(a), 4);
            
            Console.WriteLine(Round(z1, 3));
            Console.WriteLine(Round(z2, 3));
            
            // 6 variant
            z1 = Cos(a) + Cos(2 * a) + Cos(6 * a) + Cos(7 * a);
            z2 = 4 * Cos(a / 2) * Cos((double) 5 / 2) * Cos(4 * a);

            Console.WriteLine(Round(z1, 3));
            Console.WriteLine(Round(z2, 3));
            
            // 7 variant
            z1 = Pow(Cos((double) 3 / 8 * PI - a / 4), 2) - Pow((double) 11 / 8 * PI + a / 4, 2);
            z2 = Sqrt(2) / 2 * Sin(a / 2);
            
            Console.WriteLine(z1);
            Console.WriteLine(z2);
            
            // 9 variant
            double b = Convert.ToDouble(Console.ReadLine()); // WARNING! To variable (a, b);

            z1 = Pow(Cos(a) - Cos(b), 2) - Pow(Sin(a) - Sin(b), 2);
            z2 = -4.0 * Pow(Sin((a - b) / 2), 2) * Cos(a + b);
            
            Console.WriteLine(z1);
            Console.WriteLine(z2);
        }
        
        /// /////////////////////////////////////////////////////////////////
        /// // Second Task
        /// /////////////////////////////////////////////////////////////////
        
        static void Task2()
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double x = Convert.ToDouble(Console.ReadLine());
            
            // 1 variant
            double y = Sqrt(a + b) < x ? a * x * x + b * Log10(Abs(2 * x)) : Sqrt(a + Sin(2 * x));
            Console.WriteLine(y);
            
            // 2 variant
            double y1 = 3 * a > b ? Log(x * x) - Pow(E, x / 3) : Atan(2 * x - 0.6);
            Console.WriteLine(y1);
            
            // 3 variant
            double y2 = 3 * b * b > a ? Pow(E, Sin(x)) + b : Pow(E, -x) + a * Log10(x);
            Console.WriteLine(y2);
            
            // 4 variant
            double y3 = Abs(a * a - b * b) > b ? Pow(a, x / 2) - Pow(E, Cos(x)) : Tan(4 * x) - a;
            Console.WriteLine(y3);
            
            // 7 variant
            double y6 = a * x < b ? Pow(E, -2 * x) + Pow(Pow(a, 4) + x, (double) 1 / 4) : Sin(x) - b * b;
            Console.WriteLine(y6);
            
            // 10 variant
            double y9 = 3 * a > 2 * b ? Log(x * x) - Asin(x / 10) : Atan(2 * x - 0.6) + 2 * Log(x);
            Console.WriteLine(y9);
        }
        
        /// /////////////////////////////////////////////////////////////////
        /// // Third Task
        /// /////////////////////////////////////////////////////////////////
        
        static void Task3()
        {
            int year = Convert.ToInt32(Console.ReadLine()) - 4;

            int check = year % 12;

            switch (check)
            {
                case 0: Console.WriteLine("крысы");
                    break;
                case 1 : Console.WriteLine("коровы");
                    break;
                case 2: Console.WriteLine("тигра");
                    break;
                case 3 : Console.WriteLine("зайца");
                    break;
                case 4 : Console.WriteLine("дракона");
                    break;
                case 5 : Console.WriteLine("змеи");
                    break;
                case 6 : Console.WriteLine("лошади");
                    break;
                case 7 : Console.WriteLine("овцы");
                    break;
                case 8 : Console.WriteLine("обезьяны");
                    break;
                case 9 : Console.WriteLine("петуха");
                    break;
                case 10 : Console.WriteLine("собаки");
                    break;
                case 11 : Console.WriteLine("свиньи");
                    break;
                default: Console.WriteLine("LOL");
                    break;
            }
        }
     } 
}
