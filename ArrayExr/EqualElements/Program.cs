using System;
using System.Linq;

namespace EqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 1;
            int start = 0;
            int end = 0;
            int maxCount = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if(array[i] == array[j])
                    {
                        count++;
                        if(count > maxCount)
                        {
                            maxCount = count;
                            start = i;
                            end = j;
                        }
                    }
                    else
                    {
                        count = 1;
                        break;
                    }
                }
                count = 1;
            }

            for (int i = start; i <= end; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
