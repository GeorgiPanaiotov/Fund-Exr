using System;
using System.Collections.Generic;

namespace HW7
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Dictionary<char, int> values = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if(text[i] == ' ')
                {
                    continue;
                }
                if (values.ContainsKey(text[i]))
                {
                    int currValue = values[text[i]];
                    currValue++;
                    values.Remove(text[i]);
                    values.Add(text[i], currValue);
                }
                else
                {
                    values.Add(text[i], 1);
                }
            }
            foreach (var letter in values)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }

        }
    }
}
