using System;
using System.Collections.Generic;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            printMessage("Enter student name: ");
            string name = Console.ReadLine();
            printMessage("Enter your id: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                printMessage("Invalid id. Enter a valid integer: ");
            }
            Student s1 = new Student(name, id);
            const int GradesCount = 5;
            for (int i = 1; i <= GradesCount; i++)
            {
                printMessage($"Enter grade {i}: ");


                float grade;
                while (!float.TryParse(Console.ReadLine(), out grade))
                {
                    printMessage("Invalid grade. Enter a valid number: ");
                }
                s1.Grades.Add(grade);
            }
            Console.WriteLine("\n----Student record----");
            Console.WriteLine($"Name: {s1.Name}");
            Console.WriteLine($"Id: {s1.Id}");
            Console.WriteLine($"Average: {s1.GetAverage():F2}");
            Console.ReadKey();
        }
        static void printMessage(string message)
        {
            Console.Write(message);
        }
    }
    class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<float> Grades { get; set; }
        public Student(string name, int id)
        {
            Name = name;
            Id = id;
            Grades = new List<float>();
        }
        public float GetAverage()
        {
            if (Grades.Count == 0) return 0f;
            float sum = 0f;
            foreach (float grade in Grades) sum += grade;
            return sum / Grades.Count;
        }
    }
}


