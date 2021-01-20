using System;
using System.Text.RegularExpressions;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            Validator(Console.ReadLine());
        }
        static void Validator(string input)
        {
            bool isLong = false;
            if(input.Length >= 6 && input.Length <= 10)
            {
                isLong = true;
            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isLong = false;
            }

            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            bool hasSym = false;
            if (hasSymbols.IsMatch(input))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                hasSym = false;
            }
            else
            {
                hasSym = true;
            }

            var hasNumber = new Regex(@"[0-9][0-9]");
            bool hasNum = false;
            if (hasNumber.IsMatch(input))
            {
                hasNum = true;
            }
            else
            {
                Console.WriteLine("Password must have at least 2 digits");
                hasNum = false;
            }
            if(isLong && hasSym && hasNum)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
