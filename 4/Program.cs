using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] strArr = str.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            ShowSortedCollectionOfWords(strArr);
            Console.ReadKey();
        }

        static void ShowSortedCollectionOfWords(string[] array)
        {
            Array.Sort(array);
            Console.WriteLine("Words: {0}", array.Length);

            foreach (var word in array)
            {
                Console.WriteLine(word);
            }
        }
    }
}
