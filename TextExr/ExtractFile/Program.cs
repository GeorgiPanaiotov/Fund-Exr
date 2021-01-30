using System;
using System.Linq;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('\\').ToArray();
            string last = input[input.Length - 1];

            int end = 0;
            for (int i = 0; i < last.Length; i++)
            {
                if(last[i] == '.')
                {
                    end = i;
                    break;
                }
            }

            string name = string.Empty;
            for (int i = 0; i < end; i++)
            {
                name += last[i];
            }
            string ext = string.Empty;
            for (int i = end + 1; i < last.Length; i++)
            {
                ext += last[i];
            }

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {ext}");
        }
    }
}
