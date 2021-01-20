using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(VowelsCounter(Console.ReadLine()));
        }

        static int VowelsCounter(string input)
        {
            input = input.ToLower();
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] == 'a' || input[i] == 'e' || input[i] == 'u' || input[i] == 'i' || input[i] == 'o')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
