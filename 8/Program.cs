using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Int32.Parse(Console.ReadLine());
            if (n <= 100)
            {
                var array = GetNumberToArray(n);
                ShowPalindroms(array);
            }

            Console.ReadLine();
        }

        static List<int> GetNumberToArray(int n)
        {
            var array = new List<int> { };
            for (int i = 0; i < n; i++)
            {
                if (IsPalindrome(i))
                {
                    array.Add(i);
                }
            }
            return array;
        }

        static bool IsPalindrome(int number)
        {
            var reverseNumber = new string(number.ToString().Reverse().ToArray());

            return string.Equals(number.ToString(), reverseNumber);
        }

        static void ShowPalindroms(List<int> array)
        {
            foreach (var element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}
