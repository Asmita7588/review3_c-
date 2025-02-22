using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace review3
{
    internal class EvenOddChecker
    {
        //4) Even/Odd Checker
        // Create a lambda expression that checks whether a number is even or odd.
        //5).String Length Comparison
        //Use a lambda expression to compare two strings based on their lengths.

        public void IsEvenOdd() {

            Func<int, bool> isEven = num => num % 2 == 0;

                int num = 4;
            
                if (isEven(num))
                {
                    Console.WriteLine($"{num} is even.");
                }
                else
                {
                    Console.WriteLine($"{num} is odd.");
                }
            


        }

        public void StringLengthCom()
        {
            List<string> strings = new List<string> { "apple", "banana"};

            var sortedStrings = strings.OrderBy(s => s.Length).ToList();

            Console.WriteLine("Strings sorted by length:");
            foreach (string s in sortedStrings)
            {
                Console.WriteLine(s);
            }


            Console.WriteLine("\nComparing strings by length:");
            for (int i = 0; i < sortedStrings.Count - 1; i++)
            {
                string s1 = sortedStrings[i];
                string s2 = sortedStrings[i + 1];

                if (s1.Length < s2.Length)
                {
                    Console.WriteLine($"'{s1}' is shorter than '{s2}'");
                }
                else if (s1.Length == s2.Length)
                {
                    Console.WriteLine($"'{s1}' and '{s2}' have the same length");
                }
                else
                {
                    Console.WriteLine($"'{s1}' is longer than '{s2}'");
                }
            }


         }

    }
}
