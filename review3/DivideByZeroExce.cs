using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review3
{
    internal class DivideByZeroExce
    {

        public static void Div()
        {
            Console.WriteLine("Enter numerator :");
            if (!double.TryParse(Console.ReadLine(), out double numerator))
            {
                Console.WriteLine(" Error :invalid input, please provide valid input");
            }

            Console.WriteLine("Enter denominator :");
            if (!double.TryParse(Console.ReadLine(), out double denominator))
            {
                Console.WriteLine(" Error :invalid input, please provide valid input");
            }
           double result = DivideByZeroExce.Division(numerator, denominator);

            Console.WriteLine("Divison result = " + result);

        }
        public  static double Division(double x, double y)
        {  

          if(y == 0)
            {
                throw new DivideByZeroException();
            }
            return x / y;
        }


    }
}
