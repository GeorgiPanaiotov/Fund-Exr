using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            string typeOfPeople = Console.ReadLine();
            string dayOfStay = Console.ReadLine();
            double total = 0;

            switch (typeOfPeople)
            {
                case "Students":
                    switch (dayOfStay)
                    {
                        case "Friday":
                            if(numberOfPeople >= 30)
                            {
                                total = (numberOfPeople * 8.45 - numberOfPeople * 8.45 * 0.15);
                            }
                            else
                            {
                                total = numberOfPeople * 8.45;
                            }
                            break;
                        case "Saturday":
                            if (numberOfPeople >= 30)
                            {
                                total = (numberOfPeople * 9.80 - numberOfPeople * 9.80 * 0.15);
                            }
                            else
                            {
                                total = numberOfPeople * 9.80;
                            }
                            break;
                        case "Sunday":
                            if (numberOfPeople >= 30)
                            {
                                total = (numberOfPeople * 10.46 - numberOfPeople * 10.46 * 0.15);
                            }
                            else
                            {
                                total = numberOfPeople * 10.46;
                            }
                            break;
                    }
                    break;
                case "Business":
                    switch (dayOfStay)
                    {
                        case "Friday":
                            if (numberOfPeople >= 100)
                            {
                                total = (numberOfPeople - 10) * 10.90;
                            }
                            else
                            {
                                total = numberOfPeople * 10.90;
                            }
                            break;
                        case "Saturday":
                            if (numberOfPeople >= 100)
                            {
                                total = (numberOfPeople - 10) * 15.60;
                            }
                            else
                            {
                                total = numberOfPeople * 15.60;
                            }
                            break;
                        case "Sunday":
                            if (numberOfPeople >= 100)
                            {
                                total = (numberOfPeople - 10) * 16;
                            }
                            else
                            {
                                total = numberOfPeople * 16;
                            }
                            break;
                    }
                    break;
                case "Regular":
                    switch (dayOfStay)
                    {
                        case "Friday":
                            if (numberOfPeople >= 10 && numberOfPeople <= 20)
                            {
                                total = (numberOfPeople * 15 - numberOfPeople * 15 * 0.05);
                            }
                            else
                            {
                                total = numberOfPeople * 15;
                            }
                            break;
                        case "Saturday":
                            if (numberOfPeople >= 10 && numberOfPeople <= 20)
                            {
                                total = (numberOfPeople * 20 - numberOfPeople * 20 * 0.05);
                            }
                            else
                            {
                                total = numberOfPeople * 20;
                            }
                            break;
                        case "Sunday":
                            if (numberOfPeople >= 10 && numberOfPeople <= 20)
                            {
                                total = (numberOfPeople * 22.50 - numberOfPeople * 22.50 * 0.05);
                            }
                            else
                            {
                                total = numberOfPeople * 22.50;
                            }
                            break;
                    }
                    break;
            }
            Console.WriteLine($"Total price: {total:f2}");
        }
    }
}
