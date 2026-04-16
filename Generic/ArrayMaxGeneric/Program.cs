using System;


namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int size = 10;
            int[] arr = new int[size];

            Random rand = new Random();

            for (int i = 0; i < size; i++)
            {
                arr[i] = rand.Next(1, 100); 
            }
            Console.WriteLine("Array is :");
            foreach (var item in arr)
            {
                Console.Write(item+", ");
            }
            Console.WriteLine("\nMax from the array is : " + ArrayMax(arr));
        } 
           
    
    

    public static T ArrayMax<T>(T[] array) where T : IComparable
        {
            if (array.Length == 0)
            {
                throw new ArgumentNullException("Array is Null");
            }
            T max = array[0];
            foreach (var item in array)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }

            }
            return max;

        }
    }
}