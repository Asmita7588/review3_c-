using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace review3
{
    internal class FindDuplicateWord
    {

        //Find Duplicate Words
        // Write a Regex to find all duplicate words in a sentence(e.g., "This is is a test test").

        public static string[] FindDuplicateWordEx(string str)
        {

            string pattern = @"\b(\w+)\b(?=.*\b\1\b)";



            var matches = Regex.Matches(str, pattern, RegexOptions.IgnoreCase);

            var duplicates = matches.Cast<Match>().Select(match => match.Groups[1].Value.ToLower()).Distinct().ToArray();

            

            return duplicates;

        }

    }
}
