using System;
using System.Linq;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while(input != "END")
            {
                Palindrome(input);
                input = Console.ReadLine();
            }
        }
        static void Palindrome(string input)
        {
            string reverse = new string (input.Reverse().ToArray());
            if(input == reverse)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
