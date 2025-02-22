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
    internal class ValidateEmail
    {
        //1)Email Validation
        // Write a program that validates email addresses using Regex.
        //The email should follow the format: username @domain.extension.

        public static  bool IsValidEmail(string email)
        {
            string emailRegex = @"^[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]$";

            Regex emailReg = new Regex(emailRegex);

            Match match = emailReg.Match(email);
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
