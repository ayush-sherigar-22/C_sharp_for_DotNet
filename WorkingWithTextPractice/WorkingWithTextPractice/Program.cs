using System;

namespace WorkingWithTextPractice
{
    public class Program
    {

        /*1- Write a program and ask the user to enter a few numbers separated by a hyphen. 
         * Work out if the numbers are consecutive. 
         * For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
         * display a message: "Consecutive"; otherwise, display "Not Consecutive".*/



        public static void Main(string[] args) {

            Console.WriteLine("Enter numbers separated by hyphen : ");
            var input  = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid");
            }

          var numList =  input.Split("-")
                               .Select(n => int.Parse(n.Trim()))
                               .ToList();
          bool flag = false;
          for(int i = 0;  i<numList.Count-1; i++)
            {
                if (numList[i+1] != numList[i] + 1)
                {
                    Console.WriteLine("Not Consecutive.");
                    flag = true;
                    break;
                }

          }
            if (!flag)
            {
                Console.WriteLine("Consecutive");
            }
                
        }
    }
}