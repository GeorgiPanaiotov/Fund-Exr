using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> result = new List<int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (j > array.Length)
                    {
                        break;
                    }
                    if (array[i] + array[j] == n)
                    {
                        result.Add(array[i]);
                        result.Add(array[j]);
                    }
                }
            }

            for (int i = 0; i < result.Count; i += 2)
            {
                Console.Write(result[i] + " " + result[i + 1]);
                Console.WriteLine();
            }
        }
    }
}
