using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourses = new Dictionary<string, int>();


            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                for (int i = 0; i <= input.Length; i += 2)
                {
                    int current = int.Parse(input[i]);
                    string resourse = input[i + 1];
                    if (resourses.ContainsKey(resourse))
                    {
                        int cur = resourses[resourse];
                        cur += current;
                        resourses.Remove(resourse);
                        resourses.Add(resourse, cur);
                    }
                    else
                    {
                        resourses.Add(resourse, current);
                    }
                    input = Console.ReadLine().Split().ToArray();
                }
            }
        }
    }
}
