using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            List<Person> people = new List<Person>();

            while(input[0] != "End")
            {
                Person person = new Person(input[0], input[1], int.Parse(input[2]));
                people.Add(person);
                input = Console.ReadLine().Split().ToArray();
            }

            people = people.OrderBy(x => x.Age).ToList();

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }
    public class Person
    {
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
    }
}
