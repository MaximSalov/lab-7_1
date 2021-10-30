using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны первого треугольника");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стороны второго треугольника");
            int d = Convert.ToInt32(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());
            int f = Convert.ToInt32(Console.ReadLine());
            double S1, S2;
            calcArea(a, b, c, d, e, f, out S1, out S2);
            if (S1 > S2)
            {
                Console.WriteLine("Площадь первого треугольника {0,4:f2} больше второго {1,4:f2}", S1, S2);
            }
            else
            {
                Console.WriteLine("Площадь второго треугольника {0,4:f2} больше первого {1,4:f2}", S2, S1);
            }
            Console.ReadKey();
        }
        static void calcArea(int a, int b, int c, int d, int e, int f, out double S1, out double S2)
        {
            int p1 = (a + b + c) / 2;
            int p2 = (d + e + f) / 2;
            S1 = Math.Sqrt(p1 * (p1 - a) * (p1 - b) * (p1 - c));
            S2 = Math.Sqrt(p2 * (p2 - d) * (p2 - e) * (p2 - f));
        }
    }
}

