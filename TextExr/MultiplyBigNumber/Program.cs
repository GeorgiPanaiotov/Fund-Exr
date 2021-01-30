using System;
using System.Numerics;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());
            BigInteger big = new BigInteger();
            big = number * n;

            Console.WriteLine(big);
        }
    }
}
