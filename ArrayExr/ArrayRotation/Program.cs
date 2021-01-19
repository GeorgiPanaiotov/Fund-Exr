using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                numbers.Enqueue(arr[i]);
            }
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int curr = numbers.Dequeue();
                numbers.Enqueue(curr);
            }

            Console.WriteLine(String.Join(' ', numbers));
        }
    }
}
