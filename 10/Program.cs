using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine();
            var b = Console.ReadLine();
            var c = Console.ReadLine();

            var number = a + b + c;
            int integerNumber;
            if (Int32.TryParse(number, out integerNumber))
                ShowSwaps(number);
            else
                Console.WriteLine("Error!");
            Console.ReadKey();
        }

        static void ShowSwaps(string number)
        {
            List<string> combinations = new List<string>();
            for (int i = 0; i < number.Length; i++)
            {
                for (int j = 0; j < number.Length; j++)
                {
                    if (j == i)
                        continue;
                    for (int k = 0; k < number.Length; k++)
                    {
                        if (k == j || k == i)
                            continue;

                        var newNumber = number[i].ToString() + number[j].ToString() + number[k].ToString();
                        if (!combinations.Contains(newNumber))
                        {
                            combinations.Add(newNumber);
                            Console.WriteLine(newNumber);
                        }
                    }
                }
            }
        }


    }
}
