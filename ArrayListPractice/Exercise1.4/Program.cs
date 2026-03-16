using System;
using System.Diagnostics.Contracts;
using System.Globalization;


/*4- Write a program and ask the user to continuously enter a number or type "Quit" to exit.
 * The list of numbers may include duplicates. 
 * Display the unique numbers that the user has entered.
*/

namespace ArrayListPractice
{

    public class Program
    {
        public static void Main(string[] args)
        {

            List<int> number = new List<int>();

            while (true)
            {
                Console.Write("Enter a number or quit to stop : ");
                var input = Console.ReadLine();
                if (!int.TryParse(input, out int n))
                {
                    if (input.ToLower() == "quit")
                    {
                        Console.WriteLine("Enter Numbers are:");
                        foreach (var num in number)
                        {
                            Console.WriteLine(num);
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Try again");
                        continue;
                    }
                }
                else if (number.Contains(n))
                {
                    continue;
                }

                number.Add(n);
                continue;

            }
            
        }
    } 
}