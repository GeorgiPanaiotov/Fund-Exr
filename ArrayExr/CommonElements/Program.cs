using System;
using System.Collections.Generic;
using System.Linq;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split().ToArray();
            string[] array2 = Console.ReadLine().Split().ToArray();
            List<string> result = new List<string>();
            for (int i = 0; i < array2.Length; i++)
            {
                if (array1.Contains(array2[i]))
                {
                    result.Add(array2[i]);
                }
            }
            foreach (var text in result)
            {
                Console.Write(text + " ");
            }
        }
    }
}
