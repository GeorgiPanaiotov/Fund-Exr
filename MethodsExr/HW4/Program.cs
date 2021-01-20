using System;
using System.Linq;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSmallest(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        }
        static void PrintSmallest(int first, int second, int third)
        {
            int[] array = new int[] { first, second, third };
            array = array.OrderBy(x => x).ToArray();
            Console.WriteLine(array[0]);
        }
    }
}
