using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LoopPractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CheckPrime();
            //PatternTillNum();
            //ReverseNummComp();
            //StrongNumCheck();
             NumCount();
        }

        public static void CheckPrime()
        {
            // Prime number till a range
            Console.WriteLine("Enter a number :");
            var input = Console.ReadLine();
            bool flag = false;
            if (int.TryParse(input, out int num))
            {
                if (num == 1)
                {
                    Console.WriteLine("1 is niether Prime nor Composite");

                }
                for (int i = 2; i < Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine("Number isn't Prime.");
                        flag = true;
                        break;
                    }
                }

                if (!flag)
                {
                    Console.WriteLine("Number is Prime.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }


        }

        public static void PatternTillNum()
        {
            Console.Write("Enter a range : ");
            var input = Console.ReadLine();
            if (int.TryParse(input, out int num))
            {
                for (int i = 1; i <= num; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(i);
                        }
                    }
                    Console.Write("\n");
                }
            }
        }

        public static void ReverseNummComp()
        {
            Console.WriteLine("Enter a number");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid inpput");
            }
       
            // Convert number to string to store digits in array
            char[] digits = input.ToCharArray();

            // Reverse using array
            Array.Reverse(digits);

            // Convert back to string
            string reversed = new string(digits);


            Console.WriteLine("Original Number is {0} and Reversed is  {1}: ", input, reversed);
            if (reversed.Equals(input))
            {
                Console.WriteLine("Number is a Palindrome.");
            }
            else
            {
                Console.WriteLine("Number is not a Palindrome.");
            }
          
        }

        public static void StrongNumCheck()
        {

            Console.WriteLine("Enter a number");
            string? input = Console.ReadLine(); 

            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Invalid input");
            }

            
            var result = 0;
            var counter = 0;

            while (counter < input.Length)
            {
                var fact = 1;
                var last = num % 10;
                

                for (int i = 1; i <= last; i++) 
                {
                    fact *= i;
                }

                
                num = num / 10;
                result += fact;

                
                counter++;
            }
            Console.WriteLine("Given number is : {0}",input);
            Console.WriteLine("The sum of factorial is : {0} ",result);

            if(input.Equals(result.ToString()))
            {
                Console.WriteLine("It is a Strong number");
            }
            else
            {
                Console.WriteLine("Not a Strong Number");
            }

        }


        public static void NumCount()
        {
            Console.WriteLine("Enter a number");
            var input = Console.ReadLine();


            Dictionary<char, int> freq = new Dictionary<char, int>();

            foreach(char c in input)
            {
                if (freq.ContainsKey(c))
                {
                    freq[c]++;
                }
                else
                {
                    freq[c] = 1;
                }
            }

            foreach (var item in freq)
            {
                if (item.Value > 1)
                {
                    Console.WriteLine($"{item.Key} is {item.Value} times");
                }
            }


        }
           
    }
}