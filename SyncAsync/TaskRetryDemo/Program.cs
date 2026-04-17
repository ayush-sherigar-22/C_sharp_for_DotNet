using System;
using System.Diagnostics.Contracts;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

namespace SyncAsync
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var attempt = 0;
            bool success = false;
            while (attempt < 3  && !success)
            {   
                attempt++;
                Console.WriteLine($"Attempt {attempt}...");
                try
                {
                    success = await GetData("Ayush");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error {ex.Message}");
                }
            }
            if (!success)
            {
                Console.WriteLine("Failed. Maximum attempt reached");
            }
        }
    
    
        public static async Task<bool> GetData(string name)
        {
            var random = new Random().Next(1, 5);
            Console.WriteLine("Retriving the data");
            await Task.Delay(3000);
            if (random % 2 == 0 )
            { 
                Console.WriteLine($"Data Fetched successfully for {name}");
                return true;
            }
            else
            {
                Console.WriteLine("Task failed");
                return false;
            }


        }
    }
}