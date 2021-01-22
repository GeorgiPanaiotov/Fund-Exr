using System;
using System.Collections.Generic;
using System.Linq;

namespace HW6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> people = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int capacity = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split().ToArray();


            while(input[0] != "end")
            {
                if(input.Length > 1)
                {
                    people.Add(int.Parse(input[1]));
                }
                else
                {
                    for (int i = 0; i < people.Count; i++)
                    {
                        if(people[i] + int.Parse(input[0]) <= capacity)
                        {
                            people[i] += int.Parse(input[0]);
                            break;
                        }
                        
                    }
                }
                input = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine(String.Join(' ', people));
        }
    }
}
