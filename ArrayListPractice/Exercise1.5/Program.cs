using System;
using System.Diagnostics.Contracts;
using System.Globalization;


/*5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
 * If the list is empty or includes less than 5 numbers, 
 * display "Invalid List" and ask the user to re-try; 
 * otherwise, display the 3 smallest numbers in the list.
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
                Console.Write("Enter 5 number seperated by commas: ");
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Invalid List.");
                    continue;
                }

                var tempList = input
                               .Split(',')
                               .Select(n => int.Parse(n.Trim()))
                               .ToList();
                  
                 

                if (tempList.Count == 0 || tempList.Count < 5 )
                {
                    Console.WriteLine("Invalid List. Try Again.");
                    continue;
                }

                tempList.Sort();

                Console.WriteLine("3 smallest numbers are: ");

                for (int i = 0; i < 3; i++)
                {

                    Console.WriteLine(tempList[i]);

                }
                break;

            }






        }
    }
}
    


        
    
