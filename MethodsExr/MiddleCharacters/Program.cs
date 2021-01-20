using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            MiddleChars(Console.ReadLine());
        }
        static void MiddleChars(string input)
        {
            if(input.Length % 2 == 0)
            {
                int start = input.Length / 2;
                Console.WriteLine(input.Substring(start - 1, 2));
            }
            else
            {
                int start = input.Length / 2;
                Console.WriteLine(input.Substring(start, 1));
            }
        }
    }
}
