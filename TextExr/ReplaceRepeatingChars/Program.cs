using System;
using System.Text;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append(input[0]);
            for (int i = 0; i < input.Length; i++)
            {
                if(sb[sb.Length - 1] != input[i])
                {
                    sb.Append(input[i]);
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
