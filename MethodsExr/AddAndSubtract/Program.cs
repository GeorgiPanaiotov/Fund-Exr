using System;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Subtract(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
        }
        static int Sum(int first, int second)
        {
            return first + second;
        }
        static int Subtract(int first, int second, int third)
        {
            return Sum(first, second) - third;
        }
    }
}
