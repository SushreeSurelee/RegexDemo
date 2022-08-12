using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexDemo
{
    class RegexDemo
    {
        public void TestRegex(string[] inputs, string pattern)
        {
            foreach (string input in inputs)
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Console.WriteLine("Valid");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
        }
        public void ValidatePinCode()
        {
            string[] inputs = { "400088","A400088","400088B","400 088" };
            string pattern = "^[1-9][0-9]{2}[ ]?[0-9]{3}$";
            TestRegex(inputs, pattern);
        }
        public void ValidateCharacter()
        {
            string[] input = { "111", "1aaa", "aa11", "bcc", "1a1aab", "1abb23a" };
            string pattern = "^[0-9]*[a-zA-Z]{3}[0-9a-zA-Z]*$";
            TestRegex(input, pattern);
        }
    }
}
