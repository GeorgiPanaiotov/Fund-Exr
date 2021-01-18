using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string money = Console.ReadLine();
            double total = 0;
            while (money != "Start")
            {
                if (double.Parse(money) == 0.1
                    || double.Parse(money) == 0.2
                    || double.Parse(money) == 0.5
                    || double.Parse(money) == 1
                    || double.Parse(money) == 2)
                {
                    total += double.Parse(money);
                }
                else
                {
                    Console.WriteLine($"Cannot accept {money}");
                }
                money = Console.ReadLine();
            }

            string product = Console.ReadLine();
            while(product != "End")
            {
                switch (product)
                {
                    case "Nuts":
                        if(total - 2.0 >= 0)
                        {
                            Console.WriteLine($"Purchased nuts");
                            total -= 2.0;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (total - 0.7 >= 0)
                        {
                            Console.WriteLine($"Purchased water");
                            total -= 0.7;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (total - 1.5 >= 0)
                        {
                            Console.WriteLine($"Purchased crisps");
                            total -= 1.5;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (total - 0.8 >= 0)
                        {
                            Console.WriteLine($"Purchased soda");
                            total -= 0.8;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (total - 1.0 >= 0)
                        {
                            Console.WriteLine($"Purchased coke");
                            total -= 1.0;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;

                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {total:f2}");
        }
    }
}
