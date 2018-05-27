using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input number:");
            string inputData = Console.ReadLine();

            var number = 0;
            if (Int32.TryParse(inputData, out number))
            {
                Console.WriteLine("Your Number is: {0} and {1}", F1(number), F2(number));
            }

            Console.ReadKey();
        }

        public static string F1(int number)
        {
            if (number % 2 == 0)
                return "Even";
            else return "Odd";
        }

        public static string F2(int number)
        {
            var temp = 0;

            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                    temp++;
            }

            if (temp > 0)
                return "Composite";
            else return "Simple";
        }

    }
}
