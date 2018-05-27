using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Int32.Parse(Console.ReadLine());
            var evalsArray = EvalsArray(n);
            DisplayArray(evalsArray);
            Console.ReadKey();
        }

        static List<int> EvalsArray(int size)
        {
            var evalsArray = new List<int> { };

            for (int i = 0; i < size; i++)
            {
                if (i % 2 == 0)
                {
                    evalsArray.Add(i);
                }
            }
            return evalsArray;
        }

        static void DisplayArray(List<int> evalsAr)
        {
            foreach (var element in evalsAr)
            {
                Console.WriteLine(element);

            }

            Console.WriteLine("SUM = {0}", evalsAr.Sum());
        }

    }
}
