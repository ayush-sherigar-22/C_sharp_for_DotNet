using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace LINQ
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var students = new List<Student>
                                {
                                new Student { Name = "Amit", Age = 20, Marks = 85 },
                                new Student { Name = "Neha", Age = 22, Marks = 35 },
                                new Student { Name = "Rahul", Age = 21, Marks = 90 },
                                new Student { Name = "Priya", Age = 19, Marks = 20 },
                                new Student { Name = "Karan", Age = 23, Marks = 60 },
                                new Student { Name = "Sneha", Age = 20, Marks = 40 },
                                new Student { Name = "Vikas", Age = 24, Marks = 55 },
                                new Student { Name = "Pooja", Age = 21, Marks = 99 },
                                new Student { Name = "Arjun", Age = 22, Marks = 78 },
                                new Student { Name = "Meera", Age = 20, Marks = 88 }
                            };

            var topperStudent = students.Where(marks => marks.Marks > 75)
                                         .OrderByDescending(marks => marks.Marks)
                                         .Select(std => std.Name + " " + std.Marks);

            Console.WriteLine("Topper Students are :");
            foreach(var std in topperStudent)
            {
                Console.WriteLine(std);
            }
            Console.WriteLine("\n---------------------------------------------------------");

            var average = students.Select(n => n.Marks).Average();
            Console.WriteLine("Class Average is :"+ average);
            Console.WriteLine("\n---------------------------------------------------------");

            var highestMark = students.Select(n => n.Marks + " by " + n.Name).Max();
            Console.WriteLine("Highest Mark achieved "+ highestMark);
            Console.WriteLine("\n---------------------------------------------------------");

            var lowestMark = students.Select(n => n.Marks + " by "+ n.Name).Min();
            Console.WriteLine("Lowest Mark achieved " + lowestMark);

            var belowAverage = students.Where(n => n.Marks < average)
                                       .Select(n=>n.Name);

            Console.WriteLine("\n---------------------------------------------------------");

            Console.WriteLine("Below Average Students are :");
            foreach (var std in belowAverage)
            {
                Console.WriteLine(std);
            }
            Console.WriteLine("\n---------------------------------------------------------");


            var aboveAverage = students.Where(n => n.Marks > average)
                                        .Select(n => n.Name); ;
            
            Console.WriteLine("Above Average Students are :");
            foreach (var std in aboveAverage)
            {
                Console.WriteLine(std);
            }
            Console.WriteLine("\n---------------------------------------------------------");


            var result = students.GroupBy(s => s.Marks >= 40);

            foreach (var group in result)
            {
                Console.WriteLine(group.Key ? "Pass" : "Fail");

                foreach (var student in group)
                {
                    Console.WriteLine($"{student.Name} - {student.Marks}");
                }

                Console.WriteLine();
            }
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }
    }
}