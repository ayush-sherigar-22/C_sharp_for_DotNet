using System;

namespace Delegates

{
    public class Program
    {
        public static void Main(string[] args) 
        {
            var processor = new OrderProcessing();
            var order = new Order(123, 4432);
            OrderHandler handler = processor.ValidateOrder;
             handler += processor.ApplyDiscount;
            handler += processor.PaymentProcess;
            handler += processor.Notification;
            handler += processor.PrintReciept;


            var orderProcess = new Processor(); 
            orderProcess.ProcessOrder(order, handler);
        }
    }

    public class Order
    {
        public int OrderID { get; set; }
        public double Amount { get; set; }
        public bool IsValid { get; set; }
        public double FinalAmount { get; set; }

        public Order(int id, double amnt)
        {
            OrderID = id;
            Amount = amnt;
            IsValid = true;
            
        }
    }

        public delegate void OrderHandler(Order order);

    public class OrderProcessing
    {
       public void ValidateOrder(Order order) 
       {
            if (order.Amount <= 0)
            {
                order.IsValid = false;
                Console.WriteLine("Order is : Invalid");
            }
            else
            {
                order.IsValid = true;
                Console.WriteLine("Order is :  Valid");
            }
       }

        public void ApplyDiscount(Order order)
        {
           
            if (order.Amount<=0)
            {
                order.FinalAmount = 0;
                
            }
            order.FinalAmount = order.Amount - order.Amount *0.2;
            Console.WriteLine("20% Discount applied");
        }

        public void PaymentProcess(Order order)
        {
            Console.WriteLine($"Payment Processed for order {order.OrderID}");
        }

        public void Notification(Order order)
        {
            Console.WriteLine($"Order has been confirmed. Invoice will be generated soon.");
            Thread.Sleep(1000);
        }

        public void PrintReciept(Order order)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Order Id is : {order.OrderID}");
            Console.WriteLine($"Original Amount was : {order.Amount}");
            Console.WriteLine($"Final Price after discount : {order.FinalAmount}");
            Console.WriteLine($"Payment Status : Paid");
            Console.WriteLine("--------------------------------");
        }
    }

    public class Processor
    {
        public void ProcessOrder(Order order, OrderHandler handler)
        {
            

            if (order.IsValid)
            {
                Console.WriteLine("Order is invalid. Stopping process.");
                return;
            }
            else
            {
                handler(order);
            }
        }
    }
}


