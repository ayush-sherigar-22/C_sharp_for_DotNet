using System;
using System.IO.Enumeration;
using System.Security.AccessControl;

namespace SyncAsync
{
    public class Program
    {
        public static async Task Main(string[] args)
        {

            DownloadFile("File A", 3);
            DownloadFile("File B", 3);


            Task file3 = DownloadFileAsync("File C", 3);

            Task file4 = DownloadFileAsync("File D", 2);

            await Task.WhenAll(file3, file4);


        }


        // Async 
        public static async Task DownloadFileAsync(string fileName, int fileSize)
        {
            if (fileSize >= 3)
            {
                Console.WriteLine($"The file name is :{fileName}");
                await Task.Delay(3000);
                Console.WriteLine($"{fileName} Downloaded Successfully of size {fileSize}mb");
                return;
            }

            Console.WriteLine($"The file name is :{fileName}");
            await Task.Delay(3000);
            Console.WriteLine($"{fileName} Downloaded Successfully of size {fileSize}mb");
        }

        //Sync

        public static void DownloadFile(string fileName, int fileSize)
        {
            if (fileSize >= 3)
            {
                Console.WriteLine($"The file name is :{fileName}");
                Thread.Sleep(3000);
                Console.WriteLine($"{fileName} Downloaded Successfully of size {fileSize}mb");
                return;
            }

            Console.WriteLine($"The file name is :{fileName}");
            Thread.Sleep(2000);
            Console.WriteLine($"{fileName} Downloaded Successfully of size {fileSize}mb");
        }
    }
}
