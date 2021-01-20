using System;
using System.Collections.Generic;
using System.Linq;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            List<char> reverse = username.Reverse().ToList();
            string password = string.Empty;
            for (int i = 0; i < reverse.Count; i++)
            {
                password += reverse[i];
            }

            for (int i = 0; i <= 3; i++)
            {
                string input = Console.ReadLine();
                if(input == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    Environment.Exit(0);
                }
                else
                {
                    if(i == 3)
                    {
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                    
                }
            }
            Console.WriteLine($"User {username} blocked!");
        }
    }
}
