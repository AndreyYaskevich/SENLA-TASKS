using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Double.Parse(Console.ReadLine());
            double b = Double.Parse(Console.ReadLine());
            double c = Double.Parse(Console.ReadLine());

            Console.WriteLine(IsPossiblyRightTriangle(a, b, c) && IsTriangleExist(a, b, c));

            Console.ReadKey();
        }

        static bool IsTriangleExist(double a, double b, double c)
        {
            return (a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a);
        }

        static bool IsPossiblyRightTriangle(double a, double b, double c)
        {
            return (a * a == (b * b + c * c) || b * b == (a * a + c * c) || c * c == (a * a + b * b));
        }
    }
}

