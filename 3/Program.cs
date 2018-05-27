using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input word:");
            string word = Console.ReadLine();
            Console.WriteLine(IsPalindrome(word));
            Console.ReadKey();
        }

        static bool IsPalindrome(string word)
        {
            word = word.ToLower();

            var reverseWord = new string(word.Reverse().ToArray());

            return string.Equals(word, reverseWord);
        }
    }
}
