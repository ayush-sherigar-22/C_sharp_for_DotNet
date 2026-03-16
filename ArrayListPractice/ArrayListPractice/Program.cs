using System;
using System.Collections.Generic;
using System.Linq;




/*1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

If no one likes your post, it doesn't display anything.
If only one person likes your post, it displays: [Friend's Name] likes your post.
If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
Write a program and continuously ask the user to enter different names,
until the user presses Enter (without supplying a name). 
Depending on the number of names provided, display a message based on the above pattern

*/

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