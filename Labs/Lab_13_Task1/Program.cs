using System;
using static System.Math;

namespace Lab_13_Task1
{
    class Program
    {
        delegate double F(double x);
        
        static void Main(string[] args)
        {
            Console.WriteLine(solve(1, 3, 0.000001));
        }
        
        static double solve(double l, double r, double eps)
        {
            F f = x => Cos(2 / x) - 2 * Sin(1 / x) + 1 / x; // Ваша функция (на любой вкус и цвет). УЧИТЫВАЙТЕ ОДЗ!
            if (f(l) == 0) return l;
            if (f(r) == 0) return r;

            double m;
            while (r - l > eps)
            {
                double dx = (r - l) / 2;
                m = l + dx;
                if (Sign(f(l)) != Sign(f(m))) r = m;
                else l = m;
            }

            return l;
        }
        
        
        
        // бинпоиск по ответу.
        // Работает исключительно с монотонными функциями, используйте его, когда нужно найти отрезок, в котором находится решение
        // уравнения.
        static double bs()
        {
            F f = x => Cos(2 / x) - 2 * Sin(1 / x) + 1 / x; // x != 0; - Здесь функция, которую вы используете.
            
            double l = 0, r = 1e9;

            while (r - l > 1e-6)
            {
                double m = (l + r) / 2;

                if (f(m) < 0) l = m;
                else if (f(m) > 0) r = m;
                else return m;
            }

            return l;
        }
    }
}