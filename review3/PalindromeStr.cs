using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review3
{
    public class PalindromeStr
    {
        public bool IsPlaindrome(string str) {

            int left = 0;
            int right = str.Length-1;

            while (str[left] != str[right]) { 
                return false;
            }

            left++;
            right--;

            return true;

        }
    }
}
