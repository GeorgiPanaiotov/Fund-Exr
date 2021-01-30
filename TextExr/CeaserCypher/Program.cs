using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select 'Encrypt or Decrypt'");
            string selection = Console.ReadLine();
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            switch (selection)
            {
                case "Encrypt":
                    Encrypt(input, n);
                    break;
                case "Decrypt":
                    Decrypt(input, n);
                    break;
            }
        }

        public static void Encrypt(string input, int n)
        {
            string result = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                int current = input[i] + n;
                result += (char)current;
            }
            Console.WriteLine(result);
        }
        public static void Decrypt(string input, int n)
        {
            string result = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                int current = input[i] - n;
                result += (char)current;
            }
            Console.WriteLine(result);
        }
    }
}
