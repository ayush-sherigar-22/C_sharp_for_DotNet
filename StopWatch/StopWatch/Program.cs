using System;
using System.Collections;

namespace StopWatch
{

    public class Program
    {
        public static void Main(string[] args)
        {
            var watch = new StopWatch();
            while (true)
            {
                Console.WriteLine("Enter s to start the watch or q to quit");
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Invalid input provided. Try again.");
                    continue;
                }
                input = input.ToLower();
                

                if (input == "s")
                {
                    watch.StartWatch();
                    Console.WriteLine("Watch is running. Enter e to stop : ");
                    continue;
   
                }
                else if(input == "e")
                {
                    watch.EndWatch();
                    Console.WriteLine(watch.CalculateTime());
                    continue;
                }
               
                else if (input == "q")
                {

                    Console.WriteLine("Thanks for using the Watch.");
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid input . Try again");
                    continue;
                }

            }

        }
    }
}