using System;
using System.Linq;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string nums = Console.ReadLine();
            int[] numbers = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                numbers[i] = int.Parse(nums[i].ToString());
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
