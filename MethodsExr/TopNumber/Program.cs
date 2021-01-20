using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            TopNumber(int.Parse(Console.ReadLine()));
        }
        static void TopNumber(int n)
        {
            int result = 0;
            for (int i = 1; i <= n; i++)
            {
                if(i.ToString().Contains('1')
                    || i.ToString().Contains('3')
                    || i.ToString().Contains('5')
                    || i.ToString().Contains('7')
                    || i.ToString().Contains('9'))
                {
                    for (int j = 0; j < i.ToString().Length; j++)
                    {
                        result += i.ToString()[j];
                    }
                    if(result % 8 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                result = 0;
            }
        }
    }
}
