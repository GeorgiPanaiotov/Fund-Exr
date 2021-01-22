using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split().ToArray();

            while(command[0] != "end")
            {
                if(command[0] == "Delete")
                {
                    Delete(numbers, int.Parse(command[1]));
                }
                else if(command[0] == "Insert")
                {
                    Insert(numbers, int.Parse(command[1]), int.Parse(command[2]));
                }
                command = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine(String.Join(' ', numbers));
        }
        public static List<int> Delete(List<int> numbers, int number)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] == number)
                {
                    numbers.RemoveAt(i);
                    i -= 1;
                }
            }
            return numbers;
        }
        public static List<int> Insert(List<int> numbers, int element, int position)
        {
            numbers.Insert(position, element);
            return numbers;
        }
        
    }
}
