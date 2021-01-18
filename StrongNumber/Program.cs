using System;
using System.Linq;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            int result = 1;
            int[] array = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                int current = int.Parse(numbers[i].ToString());
                for (int j = 1; j <= current; j++)
                {
                    result *= j;
                }
                array[i] = result;
                result = 1;
            }
            int final = int.Parse(numbers);
            if(array.Sum() == final)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
