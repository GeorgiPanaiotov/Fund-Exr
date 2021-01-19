using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string biggest = string.Empty;
            double biggestRes = 0;
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double result = Math.PI * Math.Pow(radius, 2) * height;
                if(result > biggestRes)
                {
                    biggest = model;
                    biggestRes = result;
                }
            }
            Console.WriteLine(biggest);
        }
    }
}
