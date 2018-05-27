using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();

            Console.WriteLine(NumberOfSubstrings(text, word));

            Console.ReadKey();
        }

        static int NumberOfSubstrings(string text, string word)
        {
            var occurrences = 0;
            text = text.ToLower();
            word = word.ToLower();
            var words = text.Split(new char[] { ' ', '\n', '\r', '.', ':', ',', '?', '!', '-' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in words)
            {
                if (string.Equals(word, item))
                {
                    occurrences++;
                }
            }

            return occurrences;
        }


    }
}
