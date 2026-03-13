using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayListPractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var marks = new int[5];

            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write("Enter the marks: ");
                var input = Console.ReadLine();

                if (!int.TryParse(input, out int mark))
                    throw new Exception("Invalid marks");

                marks[i] = mark;
            }

            Console.WriteLine("\nEntered Marks are:");
            foreach (var m in marks)
                Console.WriteLine(m);

            Console.WriteLine("Highest is: " + marks.Max());
            Console.WriteLine("Lowest is: " + marks.Min());
            Console.WriteLine("Average is: " + marks.Average());

            Console.WriteLine("\n----- Using List -----");

            List<int> marks1 = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter the marks: ");
                var input = Console.ReadLine();

                if (!int.TryParse(input, out int mark))
                    throw new Exception("Invalid marks");

                marks1.Add(mark);
            }

            Console.WriteLine("\nEntered Marks are:");
            foreach (var m in marks1)
                Console.WriteLine(m);

            Console.WriteLine("Highest is: " + marks1.Max());
            Console.WriteLine("Lowest is: " + marks1.Min());
            Console.WriteLine("Average is: " + marks1.Average());
        }
    }
}