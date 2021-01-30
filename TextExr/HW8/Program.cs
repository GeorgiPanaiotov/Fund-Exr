using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace HW8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(", ").ToArray();

            Regex reg = new Regex("^[A-Za-z0-9_-]*?$");

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i].Length >=3 && array[i].Length <= 16)
                {
                    if (reg.IsMatch(array[i]))
                    {
                        Console.WriteLine(array[i]);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}
