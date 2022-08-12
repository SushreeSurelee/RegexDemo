using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            RegexDemo regex = new RegexDemo();
            regex.ValidatePinCode();
            regex.ValidateCharacter();
            Console.ReadLine();
        }
        
    }
}
