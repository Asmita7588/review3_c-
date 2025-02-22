using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review3
{
    internal class AgeExce
    {

        //Custom Age Validator
        //Write a program to input the age of a person.
        // Throw an exception if the age is less than 0 or greater than 150.

        public static void ValidateAge(int age)
        {
            if(age <= 0 || age > 150)
            {
                throw new InvalidAgeException("invalid age Input, Age should be between 1 to 150");
            }

            Console.WriteLine(" valid age input ");
        }

    }
}
