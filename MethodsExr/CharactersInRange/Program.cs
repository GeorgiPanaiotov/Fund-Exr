using System;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(' ', CharactersInAscii(char.Parse(Console.ReadLine()), char.Parse(Console.ReadLine()))));
        }

        private static char[] CharactersInAscii(char start, char end)
        {
            if(start > end)
            {
                char curr = start;
                start = end;
                end = curr;
            }
            char[] array = new char[(end - start) - 1];
            int counter = 0;
            for (int i = start + 1; i < end; i++)
            {
                array[counter] = (char)i;
                counter++;
            }
            return array;
        }
    }
}
