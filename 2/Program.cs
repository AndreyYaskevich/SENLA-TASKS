using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputDataA = Console.ReadLine();
            var inputDataB = Console.ReadLine();

            var a = 0;
            var b = 0;

            if (!Int32.TryParse(inputDataA, out a) || !Int32.TryParse(inputDataB, out b))
            {
                Console.WriteLine("Error!");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("NOD = {0}", NOD(a, b));
            Console.WriteLine("NOK = {0}", NOK(a, b));

            Console.ReadKey();
        }

        public static int NOD(int a, int b)
        {
            while (b != 0)
            {
                int tmp = b;
                b = a % b;
                a = tmp;
            }
            return a;
        }

        public static int NOK(int a, int b)
        {
            return a * b / NOD(a, b);
        }
    }
}