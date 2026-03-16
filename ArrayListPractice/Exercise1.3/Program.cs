using System;
using System.Diagnostics.Metrics;
using System.Globalization;

namespace ArrayListPractice
{

    /*3- Write a program and ask the user to enter 5 numbers. 
     * If a number has been previously entered,
     * display an error message and ask the user to re-try. 
     * Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
*/

    public class Program {

        public static void Main(string[] args) {

            var counter = 0;
            List<int> number = new List<int>();

            while (counter < 5)
            {
                Console.Write("Enter a number:");
                var input = Console.ReadLine();

                if(!int.TryParse(input, out int n))
                {
                    Console.WriteLine("Invalid number. Try again");
                    continue;
                }
                if (number.Contains(n))
                {
                    Console.WriteLine("Number alredy Exists.");
                    continue;

                }
                else
                {
                    number.Add(n);
                    counter++;
                    continue;
                }

            }
            number.Sort();
            Console.WriteLine("Soted Numbers are :");
            foreach (int n in number)
            {
                Console.WriteLine(n);
            }


        }
    
    }
}