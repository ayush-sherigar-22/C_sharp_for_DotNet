using System;

namespace OrderInterfaces
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order  = new Order
            {
                DatePlaced = DateTime.Now,
                TotalPrice = 100f,
            };

            orderProcessor.Process(order);
            Console.WriteLine($"Order will be shipped on {order.Shipment.ShippingDate} with cost {order.Shipment.Cost}");

        }

    }
}