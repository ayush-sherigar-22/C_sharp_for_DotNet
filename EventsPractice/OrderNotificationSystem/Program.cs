using System;
using System.ComponentModel.Design;

namespace EventsPractice
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            var order = new Order() { OrderId = 234};
            var processOrder = new OrderProcessor();

            var mail = new MailNotification();
            var sms = new SMSNotification();

            processOrder.OrderProcessed += mail.OnOrderProcessed;
            processOrder.OrderProcessed += sms.OnOrderProcessed;

            processOrder.Process(order);
                                         
        }
    }
}
