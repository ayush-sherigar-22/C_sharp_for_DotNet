using System;
using System.Collections.Generic;

namespace Abstraction {
    public class Program
    {
        public static void Main()
        {
            // 1. Vehicles
            Console.WriteLine("------------------");
            Console.WriteLine("# Vehicles");
            Console.WriteLine("------------------");
            List<Vehicle> vehicles = new List<Vehicle>
        {
            new Bike(),
            new Car(),
            new ElectricVechile(),
        };

            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine("Vehlice Type is :" + vehicle.FuelType());
                Console.WriteLine(vehicle.StartEngine());
                Console.WriteLine(vehicle.StopEngine());
                Console.WriteLine("------------------");
            }


            // 2. Notification system
            Console.WriteLine("------------------");
            Console.WriteLine("# Notification System");
            Console.WriteLine("------------------");
            List<NotificationSystem> notifications = new List<NotificationSystem>
        {
            new SMSNotification(),
            new EmailNotification(),
            new PushNotification()
        };

            foreach (var notification in notifications)
            {
                notification.Send("Hello");
                Console.WriteLine("------------------");
            }

            // 3. File Processor
            Console.WriteLine("------------------");
            Console.WriteLine("# File Processor");
            Console.WriteLine("------------------");
            List<FileProcessor> fileprocessor = new List<FileProcessor>
        {
            new TextFileProcessor(),
            new PDFProcessor(),
            new CSVProcessor()
        };

            foreach (var files in fileprocessor)
            {
                files.Execute();
                Console.WriteLine("------------------");
            }


            Console.WriteLine("------------------");
            Console.WriteLine("# Discount");
            Console.WriteLine("------------------");

            var amount = 5000;
            List<Discount> discounts = new List<Discount>
         {
             new FestiveDiscount(amount),
             new MembershipDiscount(amount),
             new NoDiscount(amount)
         };

            foreach (var d in discounts)
            {
                Console.WriteLine($"Original Amount is {amount}");
                var final = d.ApplyDiscount(amount);
                d.FinalPrice(final);
                Console.WriteLine("------------------");
            }



            //5.Smart Home
            Console.WriteLine("------------------");
            Console.WriteLine("# Smart Home");
            Console.WriteLine("------------------");

            List<SmartHome> appliances = new List<SmartHome>
        {
            new SmartLight(),
            new SmartFan(),
            new SmartAC()
        };

            foreach (var a in appliances)
            {
                a.TurnOn();
                a.GetStatus();

                a.TurnOff();
                a.GetStatus();

                Console.WriteLine("------------------");
            }
        }
    }
}