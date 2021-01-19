using System;
using System.Linq;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] array = new int[wagons];

            for (int i = 0; i < wagons; i++)
            {
                int people = int.Parse(Console.ReadLine());
                array[i] = people;
            }
            foreach (var person in array)
            {
                Console.Write(person + " ");
            }
            Console.WriteLine();
            Console.WriteLine(array.Sum());
        }
    }
}
