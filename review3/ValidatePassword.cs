using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace review3
{
    internal class ValidatePassword
    {
        //Password Strength Checker
        // Create a program that checks if a password:
        //Contains at least one uppercase letter, one lowercase letter, one number, and one special character.
        //Use Regex for validation.


        public static bool IsValidPassword(string password)
        {
            string passwordRegex = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[\W_]).{8,}$";

            Regex passwordReg = new Regex(passwordRegex);

            Match match = passwordReg.Match(password);
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
