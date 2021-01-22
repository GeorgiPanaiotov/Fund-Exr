using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();

            Queue<int> first = new Queue<int>(firstPlayer);
            Queue<int> second = new Queue<int>(secondPlayer);
            while(true)
            {
                int fCurr = first.Dequeue();
                int sCurr = second.Dequeue();
                if(fCurr > sCurr)
                {
                    first.Enqueue(fCurr);
                    first.Enqueue(sCurr);
                }
                else if(sCurr > fCurr)
                {
                    second.Enqueue(sCurr);
                    second.Enqueue(fCurr);
                }
                if((first.Count <= 0) || (second.Count <= 0))
                {
                    break;
                }
            }

            if(first.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {first.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {second.Sum()}");
            }
        }
    }
}
