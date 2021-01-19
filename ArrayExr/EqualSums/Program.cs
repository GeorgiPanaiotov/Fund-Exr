using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int index = -1;
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    if (j < 0)
                    {
                        break;
                    }
                    if (j > 0)
                    {
                        leftSum += array[j - 1];

                    }
                }

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (j > array.Length)
                    {
                        break;
                    }
                    rightSum += array[j];
                }
                if (leftSum == rightSum)
                {
                    index = i;
                    break;
                }
                else
                {
                    leftSum = 0;
                    rightSum = 0;
                }
            }
            if(array.Length == 1)
            {
                Console.WriteLine(0);
                Environment.Exit(0);
            }
            if (index != -1)
            {
                Console.WriteLine(index);

            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
