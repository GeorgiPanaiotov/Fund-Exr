using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Division(int.Parse(Console.ReadLine()));
            if(number == 0)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine($"The number is divisible by {number}");
            }
        }
        static int Division(int number)
        {
            if(number % 10 == 0)
            {
                return 10;
            }
            else if(number % 7 == 0)
            {
                return 7;
            }
            else if (number % 6 == 0)
            {
                return 6;
            }
            else if (number % 3 == 0)
            {
                return 3;
            }
            else if (number % 2 == 0)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
    }
}
