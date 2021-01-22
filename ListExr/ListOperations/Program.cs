using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "End")
            {
                if (command[0] == "Remove")
                {
                    if ((int.Parse(command[1]) >= numbers.Count) || (int.Parse(command[1]) < 0))
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers = Remove(numbers, int.Parse(command[1]));
                    }
                }
                else if (command[0] == "Insert")
                {
                    if ((int.Parse(command[2]) >= numbers.Count) || (int.Parse(command[2]) < 0))
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers = Insert(numbers, int.Parse(command[1]), int.Parse(command[2]));
                    }
                }
                else if (command[0] == "Add")
                {
                    numbers = Add(numbers, int.Parse(command[1]));
                }
                else if (command[0] == "Shift")
                {
                    if (command[1] == "left")
                    {
                        numbers = ShiftLeft(numbers, int.Parse(command[2]));
                    }
                    else if (command[1] == "right")
                    {
                        numbers = ShiftRight(numbers, int.Parse(command[2]));
                    }
                }
                command = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine(String.Join(' ', numbers));
        }
        public static List<int> Remove(List<int> numbers, int number)
        {
            numbers.RemoveAt(number);
            return numbers;
        }
        public static List<int> ShiftLeft(List<int> numbers, int number)
        {
            Queue<int> temp = new Queue<int>(numbers);

            for (int i = 0; i < number; i++)
            {
                int current = temp.Dequeue();
                temp.Enqueue(current);
            }
            numbers = new List<int>(temp);
            return numbers;
        }
        public static List<int> ShiftRight(List<int> numbers, int number)
        {
            numbers.Reverse();
            Queue<int> temp = new Queue<int>(numbers);

            for (int i = 0; i < number; i++)
            {
                int current = temp.Dequeue();
                temp.Enqueue(current);
            }
            numbers = new List<int>(temp);
            numbers.Reverse();
            return numbers;
        }
        public static List<int> Insert(List<int> numbers, int element, int position)
        {
            numbers.Insert(position, element);
            return numbers;
        }
        public static List<int> Add(List<int> numbers, int number)
        {
            numbers.Add(number);
            return numbers;
        }
    }
}
