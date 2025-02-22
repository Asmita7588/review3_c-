using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace review3
{
    internal class ValidatePhoneNumber
    {
        //Phone Number Validator
        //Write a program to validate phone numbers of the format +91-1234567890 or 123-456-7890.


        public static bool IsValidPhoneNumber(string phoNum)
        {
            string phoneRegex = @"^(?:\+[0-9]{2}-[0-9]{10}|[0-9]{3}-[0-9]{3}-[0-9]{4})$";

            Regex phoneReg = new Regex(phoneRegex);

            Match match = phoneReg.Match(phoNum);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
