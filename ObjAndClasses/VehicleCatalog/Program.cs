using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();

            List<Truck> trucks = new List<Truck>();
            List<Car> cars = new List<Car>();

            while (input[0] != "End")
            {
                if (input[0] == "car")
                {
                    Car car = new Car(input[1], input[2], int.Parse(input[3]));
                    cars.Add(car);
                }
                else if (input[0] == "truck")
                {
                    Truck truck = new Truck(input[1], input[2], int.Parse(input[3]));
                    trucks.Add(truck);
                }
                input = Console.ReadLine().Split(' ').ToArray();
            }

            string model = Console.ReadLine();

            while (model != "Close the Catalogue")
            {
                for (int i = 0; i < cars.Count; i++)
                {
                    if (model == cars[i].Model)
                    {
                        Console.WriteLine($"Type: {cars[i].Type}");
                        Console.WriteLine($"Model: {cars[i].Model}");
                        Console.WriteLine($"Color: {cars[i].Color}");
                        Console.WriteLine($"Horsepower: {cars[i].Horsepower}");
                        break;
                    }
                }

                for (int i = 0; i < trucks.Count; i++)
                {
                    if (model == trucks[i].Model)
                    {
                        Console.WriteLine($"Type: {trucks[i].Type}");
                        Console.WriteLine($"Model: {trucks[i].Model}");
                        Console.WriteLine($"Color: {trucks[i].Color}");
                        Console.WriteLine($"Horsepower: {trucks[i].Horsepower}");
                        break;
                    }
                }
                model = Console.ReadLine();
            }


            double resultCars = 0;
            for (int i = 0; i < cars.Count; i++)
            {
                resultCars += cars[i].Horsepower;
            }
            double resultTrucks = 0;
            for (int i = 0; i < trucks.Count; i++)
            {
                resultTrucks += trucks[i].Horsepower;
            }

            if (cars.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {(resultCars / cars.Count):f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }
            if (trucks.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {(resultTrucks / trucks.Count):f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }

        }
    }
    public class Vehicle
    {
        public string Color { get; set; }
        public int Horsepower { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
    }
    public class Car : Vehicle
    {
        public Car(string model, string color, int horsepower)
        {
            this.Type = "Car";
            this.Model = model;
            this.Color = color;
            this.Horsepower = horsepower;
        }
    }
    public class Truck : Vehicle
    {
        public Truck(string model, string color, int horsepower)
        {
            this.Type = "Truck";
            this.Model = model;
            this.Color = color;
            this.Horsepower = horsepower;
        }
    }
}
