using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                int litres = int.Parse(Console.ReadLine());
                if(result + litres > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    result += litres;
                }
            }
            Console.WriteLine(result);
        }
    }
}
