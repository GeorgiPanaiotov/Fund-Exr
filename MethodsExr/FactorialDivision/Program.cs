using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"{FactorialDivision(long.Parse(Console.ReadLine()), long.Parse(Console.ReadLine())):f2}");
        }
        static decimal FactorialDivision(long first, long second)
        {
            long firstRes = 1;
            for (int i = 1; i <= first; i++)
            {
                firstRes *= i;
            }
            long secondRes = 1;
            for (int i = 1; i <= second; i++)
            {
                secondRes *= i;
            }
            return (decimal)firstRes / (decimal)secondRes;
        }
    }
}
