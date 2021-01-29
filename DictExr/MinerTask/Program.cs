using System;
using System.Collections.Generic;

namespace MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputResourse = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            Dictionary<string, int> resourses = new Dictionary<string, int>();
            resourses.Add(inputResourse, quantity);

            while(true)
            {
                inputResourse = Console.ReadLine();
                if(inputResourse == "stop")
                {
                    break;
                }
                quantity = int.Parse(Console.ReadLine());
                if (resourses.ContainsKey(inputResourse))
                {
                    int curr = resourses[inputResourse];
                    curr += quantity;
                    resourses.Remove(inputResourse);
                    resourses.Add(inputResourse, curr);
                }
                else
                {
                    resourses.Add(inputResourse, quantity);
                }
            }
            foreach (var resourse in resourses)
            {
                Console.WriteLine($"{resourse.Key} -> {resourse.Value}");
            }

        }
    }
}
