using System;

namespace Delegates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double price = 500;

           
            Func<double, double> gstCalculator = (p) =>
            {
                return p + p * 0.18;
            };

            Func<double, double> applyDiscount = (p) =>
            {
                if (p > 500)
                    return p - p * 0.10;

                return p;
            };

            Func<double, bool> deliveryType = (p) =>
            {
                return p > 600;
            };

            
            Action<double, double, bool> process = (original, finalPrice, isFreeDelivery) =>
            {
                Console.WriteLine($"Order Amount: {original}");
                Console.WriteLine($"Final Price: {finalPrice}");
                Console.WriteLine("Order being processed...");
            };

            Action<string> status = (message) =>
            {
                Console.WriteLine(message);
            };

            Action<bool> deliveryStatus = (isFree) =>
            {
                if (isFree)
                    Console.WriteLine("Free Delivery Applied");
                else
                    Console.WriteLine("Delivery Charges Applicable");
            };

          
            double priceWithGst = gstCalculator(price);
            double finalPrice = applyDiscount(priceWithGst);
            bool isFreeDelivery = deliveryType(finalPrice);

            process(price, finalPrice, isFreeDelivery);
            status("Order has been placed successfully!");
            deliveryStatus(isFreeDelivery);
        }

    }

    }