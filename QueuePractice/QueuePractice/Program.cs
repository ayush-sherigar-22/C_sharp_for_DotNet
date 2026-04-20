using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;

namespace QueuePractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //BasicQueue();
            //BinaryTillN(20);

            List<int> nums = new List<int> { 1, 3, 5, 3, 6, 7, 5, 9 };
            SlidingWindowMax(3, nums);
        }

        public static void BasicQueue()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(20);
            queue.Enqueue(45);

            Console.WriteLine("Queue is : ");
            foreach (var i in queue)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Current count is : " + queue.Count());

            Console.WriteLine("1st element is : " + queue.Peek());
            queue.Dequeue();
            Console.WriteLine();
            Console.WriteLine("Count after Dequeue is : " + queue.Count());

            Console.WriteLine("1st element is : " + queue.Peek());

        }

        public static void BinaryTillN(int n)
        {
            Queue<string> binary = new Queue<string>();
            binary.Enqueue("1");
            Console.WriteLine($"Binary till {n} is : ");
            for (int i = 1; i <= n; i++)
            {
                var num = binary.Dequeue();
                Console.WriteLine(num);
                binary.Enqueue(num + "0");
                binary.Enqueue(num + "1");
            }

        }


        public static void SlidingWindowMax(int n, List<int> numList)
        {
            Queue<int> window = new Queue<int>();

            for (int i = 0; i <numList.Count; i++)
            {
                  window.Enqueue(numList[i]);
                if (window.Count > n)
                {
                    window.Dequeue();
                }

                if (window.Count == n)
                {
                        foreach (var num in window)
                        {
                            Console.Write(num + ",");
                        }
                        Console.WriteLine("Max is : " + window.Max());
                       
                }
                   
                       

                
            }

        }

    }
    
   
}