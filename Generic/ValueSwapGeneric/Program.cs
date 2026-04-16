using System;

namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var x = "Hello";
            var y = "World";
            Console.WriteLine("Values are :" + x+ " " + y);

            SwapbyRef(ref x, ref y);
            Console.WriteLine("Swap is "+x + " " + y);

            var a = 10; var b = 30;
            Console.WriteLine("Passed values are"+a+ " " + b);

            SwapValue(10, 30);
            Console.WriteLine("Swap is " + a + " "+ b);
        }


        public static void SwapbyRef<T>(ref T a, ref T b)
        {
           T temp = a;
           a = b; 
           b = temp;
        }

        public static (T, T) SwapValue<T>(T a, T b)
        {
            return (b, a);
        }
    }
}