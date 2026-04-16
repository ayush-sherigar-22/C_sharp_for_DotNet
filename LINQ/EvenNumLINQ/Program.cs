using System;

namespace LINQ
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3 , 4, 5, 6 , 7 , 8 };
            Console.WriteLine("Given Array : ");

            foreach(var i in array)
            {
                Console.Write(i+", ");
            }

            var evenNum = array.Where(n => n % 2 == 0);
            Console.WriteLine("\nEven Numbers are : ");
            foreach (var i in evenNum) 
            {
                    Console.Write(i+", ");
            }

            var oddNum = array.Where(n => n % 2 == 1);
            Console.WriteLine("\nOdd Numbers are : ");
            foreach (var i in oddNum)
            {
                Console.Write(i + ", ");
            }

            var squareNum = array.Select(n => Math.Pow(n, 2));
            Console.WriteLine("\nSquare of Numbers are : ");
            foreach (var i in squareNum)
            {
                Console.Write(i + ", ");
            }

            var tenPower = array.Select(n => Math.Pow(n, 10));
            Console.WriteLine("\n10 powers of Numbers are : ");
            foreach (var i in tenPower)
            {
                Console.Write(i + ", ");
            }


            // Generate a Random array
            Console.WriteLine("\n---------------------------------------------------------");
            int size = 10;
            array = new int[size];

            Random rand = new Random();

            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(1, 100); 
            }

            Console.WriteLine("Random generated array is : ");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            var operation_1 = array.Where(n => n > 10)
                                    .Select(n => n * n)
                                    .OrderBy(n=>n);
                               
            Console.WriteLine("\nSquare of Numbers greater than 10 are : ");
            foreach (var i in operation_1)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine("\n---------------------------------------------------------");
        
        } 
    }
}

           
