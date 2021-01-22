using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == array[0])
                {
                    int start = i - array[1];
                    if(start < 0)
                    {
                        for (int j = 0; j < numbers.Count; j++)
                        {
                            if(start == 0)
                            {
                                break;
                            }
                            start++;
                        }
                    }
                    int end = i + array[1];
                    int count = end - start;
                    if(start + count > numbers.Count)
                    {
                        for (int j = 0; j < numbers.Count; j++)
                        {
                            if(start + count == numbers.Count - 1)
                            {
                                break;
                            }
                            count--;
                        }
                    }
                    numbers.RemoveRange(start, count + 1);
                    i = -1;
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
