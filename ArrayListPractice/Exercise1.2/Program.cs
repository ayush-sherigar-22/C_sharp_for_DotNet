using System;
using System.Reflection.Metadata.Ecma335;

namespace ArrayListPractice
{
    /*2- Write a program and ask the user to enter their name. 
     * Use an array to reverse the name and then store the result in a new string. 
     * Display the reversed name on the console.
     */


    public class Program
    {
        public static void Main(string[] args) {

            
            while (true)
            {
                Console.WriteLine("Enter your name :");
                var input = Console.ReadLine();
                List<char> list = [];
             

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Invalid name");
                    break;

                }
                
                
                   
                for(int i = input.Length-1; i>=0 ; i--)
                {
                    
                    list.Add(input[i]);     
                }
                var result = string.Join("", list);
               Console.WriteLine(result);

                break;
                
            }
        
        }
    }
}