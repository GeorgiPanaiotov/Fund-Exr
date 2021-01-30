using System;
using System.Linq;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split().ToArray();

            Console.WriteLine(Multiplier(array[0], array[1]));
        }

        public static long Multiplier(string first, string second)
        {
            long final = 0;
            if(first.Length > second.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    if (second.Length > i)
                    {
                        int result = first[i] * second[i];
                        final += result;
                    }
                    else
                    {
                        final += first[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < second.Length; i++)
                {
                    if (first.Length > i)
                    {
                        int result = first[i] * second[i];
                        final += result;
                    }
                    else
                    {
                        final += second[i];
                    }
                }
            }
            return final;
        }
    }
}
