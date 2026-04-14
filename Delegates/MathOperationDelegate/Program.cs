using System;

namespace Delegates
{
    public class Program
    {
        public static void Main(string[] args) 
        {

            Execute(Add);
            Execute(Subtract);
            Execute(Multiply);
            Execute(Divide);
        }

        public delegate double Operation(int a, int b);
        public static double Add(int a, int b)
        {
            return a + b;
        }

        public static double Subtract(int a, int b)
        {
            return a - b;
        }
        public static double Multiply(int a, int b)
        {
            return (double)a * b;
        }
        public static double Divide(int a, int b)
        {
            return (double)a / b;
        }

        public static void Execute(Operation op)
        {
            Console.WriteLine("Result is :"+ op(5, 4));
        }

    }



}
