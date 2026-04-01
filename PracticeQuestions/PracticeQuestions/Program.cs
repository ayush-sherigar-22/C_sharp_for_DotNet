using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;


namespace PracticeQuestions
{
    public class Program {

        public static void Main(string[] args) {


            // Using Math.Pow
            Console.WriteLine("Using Math.Pow "+Power(34, 4));


            // Using For Loop
            Console.WriteLine("Using for Loop "+PowerLoop(34, 4));

            // using Lamda
            Func<double, double, double> power = (x, y) => Math.Pow(x, y);
            double n1 = 34; 
            double n2 = 4;
            Console.WriteLine("Usin lambda Fucntion "+power(n1, n2));


            // Area Problem

            Console.WriteLine("Area of a Rectangle with length {0} and breadth {1} is {2} : ",5, 6, AreaOfRectangle(5,6));
            Console.WriteLine("Area of a Circle with radius {0} is {1} : ", 6, AreaOfCircle(6));

        }

        public static double Power(double n1, double n2)
        {
            return Math.Pow(n1, n2);
        }

        public static double PowerLoop(double n1, double n2)
        {
            var result = n1;
            for (double i = 1; i <n2; i++)
            {
                result *= n1;
            }
            return result;
        }


        public static double AreaOfRectangle(double len, double breadth)
        {
            return len * breadth;
        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * radius*radius;
        }
    }
    
}