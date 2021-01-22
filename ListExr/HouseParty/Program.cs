using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = new List<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                if(input.Length > 3)
                {
                    if (people.Contains(input[0]))
                    {
                        people.Remove(input[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{input[0]} is not in the list!");
                    }
                }
                else
                {
                    if (people.Contains(input[0]))
                    {
                        Console.WriteLine($"{input[0]} is already in the list!");
                    }
                    else
                    {
                        people.Add(input[0]);
                    }
                }
            }

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
