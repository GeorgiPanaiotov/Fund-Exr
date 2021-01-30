using System;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                result += input[i];
                if(input[i] == '>')
                {
                    int currentPower = int.Parse(input[i + 1].ToString());
                    for (int j = i + 1; j <= currentPower; j++)
                    {
                        if (input[j] == '>')
                        {
                            int curr = int.Parse(input[j + 1].ToString());
                            currentPower += curr;
                            continue;
                        }
                        else
                        {
                            result += input[j];
                        }
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
