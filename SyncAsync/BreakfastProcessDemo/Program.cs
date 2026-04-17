using Microsoft.VisualBasic;
using System;
using System.Threading.Channels;

namespace SyncAsync
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            //Sync
            Console.WriteLine("Using Sync");
            MakeToast();
            MakeEggs();
            MakeCoffee();
            Console.WriteLine("Breakfast is ready..");

            // Async
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Using Async");
            Task toast = MakeToastAsync();
            Task eggs = MakeEggsAsync();
            

            await Task.WhenAll(toast, eggs); // Run parallel
            await MakeCoffeeAsync(); // Run individual
            Console.WriteLine("Breakfast is ready..");

        }
        public static async Task MakeToastAsync()
        {
            Console.WriteLine("Started making Toast..");
            await Task.Delay(3000);
            Console.WriteLine("Toast is ready");
        }

        public static async Task MakeEggsAsync()
        {
            Console.WriteLine("Started making Eggs..");
            await Task.Delay(4000);
            Console.WriteLine("Eggs are ready"); 
        }

        public static async Task MakeCoffeeAsync()
        {
            Console.WriteLine("Started making Coffee..");
            await Task.Delay(5000);
            Console.WriteLine("Coffee is ready");
        }



        public static void MakeToast()
        {
            Console.WriteLine("Started making Toast..");
            Thread.Sleep(3000);
            Console.WriteLine("Toast is ready");
        }

        public static void MakeEggs()
        {
            Console.WriteLine("Started making Eggs..");
            Thread.Sleep(4000);
            Console.WriteLine("Eggs are ready");
        }

        public static void MakeCoffee()
        {
            Console.WriteLine("Started making Coffee..");
            Thread.Sleep(5000);
            Console.WriteLine("Coffee is ready");
        }


    }



}




