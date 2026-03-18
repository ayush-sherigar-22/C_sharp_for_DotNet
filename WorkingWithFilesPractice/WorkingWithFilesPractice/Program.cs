using System;

namespace WorkingWithFilesPractice
{
    public class Program
    {

        /*1- Write a program that reads a text file and displays the number of words.

         2- Write a program that reads a text file and displays the longest word in the file.*/
        
        public static void Main(string[] args) {

            var content = File.ReadAllText(@"C:\Users\ayush\source\repos\WorkingWithFilesPractice\WorkingWithFilesPractice\PracticeFile.txt");


          /*1*/ var words = content.Split(
                new[] { ' ', '\r', '\n', '\t', '.', ',', ';', '!' },
                StringSplitOptions.RemoveEmptyEntries);
           
            
          Console.WriteLine("Number of words i the given file is : {0}",words.Length);

          /*2*/  string longWord = words[0] ;
            
            var maxLength = words[0].Length;

            foreach(var word in words)
            {
                if(maxLength < word.Length)
                {
                    maxLength = word.Length;
                    
                    longWord = word;
                }
            }
            Console.WriteLine("Lognest Word is : {0},  with {1} as length", longWord, maxLength);

        }
    } 
}