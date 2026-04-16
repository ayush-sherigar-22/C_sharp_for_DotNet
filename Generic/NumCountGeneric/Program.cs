using System;
using System.Net.Http.Headers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int size = 10;
            int[] arr = new int[] { 1, 2, 3, 4, 5, 5, 3, 3, 3, 3, 3 };


            Console.WriteLine("Array is :");
            foreach (var item in arr)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine("\n Count of the give item  is : " + NumCount(arr, 3));
            Console.WriteLine("Count of all the elements is : " );
            var result = ElementCount(arr);

            foreach (var item in result)
            {
                Console.WriteLine($"Element: {item.Key}, Count: {item.Value}");
            }
        }




        public static int NumCount<T>(T[] array, T item)
        {
            if (array.Length == 0)
            {
                throw new ArgumentNullException("Array is Empty");
            }
            var count = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(item))
                {
                    count++;
                }
            }

            return count;

        }

        public static Dictionary<T, int> ElementCount<T>(T[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            Dictionary<T, int> countDict = new Dictionary<T, int>();

            foreach (var item in array)
            {
                if (countDict.ContainsKey(item))
                {
                    countDict[item]++;
                }
                else
                {
                    countDict[item] = 1;
                }
            }

            return countDict;
        }

    }
}