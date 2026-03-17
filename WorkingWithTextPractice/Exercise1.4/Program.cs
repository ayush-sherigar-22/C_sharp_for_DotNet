using System;

namespace WorkingWithTextPractice
{
    public class Program
    {

        /*4- Write a program and ask the user to enter a few words separated by a space. 
         * Use the words to create a variable name with PascalCase. 
         * For example, if the user types: "number of students", display "NumberOfStudents". 
         * Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", 
         * the program should still display "NumberOfStudents".

*/



        public static void Main(string[] args)
        {

            Console.WriteLine("Enter a string or word: ");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid");
            }

            var numList = input.Split(" ");


            for (int i = 0; i < numList.Length; i++)
            {
                var words = numList[i];
               
                numList[i] = words[0].ToString().ToUpper() + words.Substring(1, words.Length-1).ToLower();


            }
            var result = String.Join("", numList);
            Console.WriteLine("Given word was : {0}", input);
            Console.WriteLine("Converted to Pascal case is : {0}",result);
          

        }
    }
}