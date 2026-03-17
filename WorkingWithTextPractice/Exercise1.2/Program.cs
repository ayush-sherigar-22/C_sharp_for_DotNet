using System;

namespace WorkingWithTextPractice
{
    public class Program
    {

        /*2- Write a program and ask the user to enter a few numbers separated by a hyphen. 
         * If the user simply presses Enter, without supplying an input, exit immediately; 
         * otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.
         */



        public static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Enter numbers separated by hyphen : ");
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Invalid input. Exitting program");
                    break;
                }

                var numList = input.Split("-")
                                     .Select(n => int.Parse(n.Trim()))
                                     .ToList();
                bool flag = false;
                for (int i = 0; i < numList.Count - 1; i++)
                {
                    for(int j = i+1; j< numList.Count; j++)
                    {
                        if (numList[i] == numList[j])
                        {
                            Console.WriteLine("Duplicate");
                            flag = true;
                            break;
                        }
                    }
                    if (flag) { break; }
                }
                if (!flag)
                {
                    Console.WriteLine("No Duplicate");
     
                }
            }

        }
    }
}