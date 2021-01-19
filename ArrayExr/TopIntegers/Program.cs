using System;
using System.Collections.Generic;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> result = new Queue<int>();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if(array[i] <= array[j])
                    {
                        break;
                    }
                    if(j == array.Length - 1)
                    {
                        result.Enqueue(array[i]);
                    }
                    
                }
            }
            result.Enqueue(array[array.Length - 1]);
            Console.WriteLine(String.Join(' ', result));
        }
    }
}
