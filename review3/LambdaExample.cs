using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace review3
{
    internal class LambdaExample
    {
        //7)Number Transformation
        //Given a list of integers, use a lambda expression to:
          //Multiply each number by 2.
          //Remove numbers less than 10.

        public   void FindNum()
        {
            List<int> numbers = new List<int> { 3, 5, 7, 10, 12, 15 };


            var transformedNumbers = numbers.Select (x => x*2).Where(x => x>=10).ToList();
                                     
             

            Console.WriteLine("Transformed numbers:");
            foreach (int num in transformedNumbers)
            {
                Console.WriteLine(num);
            }
        }

        public void FindMaxOfTwo()
        {
            var numbers = new List<int> { 20, 23 };

            int max = numbers.Max();


            Console.WriteLine($"The maximum value in the list is: {max}");

        }
     }
}
