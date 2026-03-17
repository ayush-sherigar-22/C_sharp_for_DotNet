using System;
using System.Reflection.Metadata;

namespace WorkingWithTextPractice
{
    public class Program
    {

        /*5- Write a program and ask the user to enter an English word. 
         * Count the number of vowels (a, e, o, u, i) in the word. 
         * So, if the user enters "inadequate", the program should display 6 on the console.
*/



        public static void Main(string[] args)
        {

            Console.WriteLine("Enter a string or word: ");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Input");
            }
            input =  input.ToLower();
            var vowels = new List<char>{'a', 'e', 'i', 'o', 'u'};
            var counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (vowels.Contains(input[i]))
                {
                    counter++;
                }


            }
            Console.WriteLine("Given word was : {0}", input);
            Console.WriteLine("Number of vowels are : {0}", counter);


        }
    }
}