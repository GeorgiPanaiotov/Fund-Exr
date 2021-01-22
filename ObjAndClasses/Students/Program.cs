using System;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Student[] student = new Student[n];
            for (int i = 0; i < n; i++)
            {
                string[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                student[i] = new Student(array[0], array[1], double.Parse(array[2]));
            }

            student = student.OrderByDescending(x => x.Grade).ToArray();

            foreach (var person in student)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
    public class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:f2}";
        }
    }
}
