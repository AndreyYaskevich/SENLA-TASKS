using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Int32.Parse(Console.ReadLine());
            var array = GenerateRandomArray(size);
            ShowArray(array);

            Console.WriteLine("Min value: {0}, Max value: {1}", array.Min(), array.Max());
            Console.ReadKey();
        }

        static int[] GenerateRandomArray(int size)
        {
            var array = new int[size];
            var random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10, 99);
            }

            return array;
        }

        static void ShowArray(int[] array)
        {
            foreach (var element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}
