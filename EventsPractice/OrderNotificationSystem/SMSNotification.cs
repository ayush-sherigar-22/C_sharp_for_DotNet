namespace EventsPractice
{
    public class SMSNotification

    {
        public void OnOrderProcessed(object source,  OrderEventArgs args)
        {
            Console.WriteLine($"[SMS Notification]: Order is processed for Order ID {args.Order.OrderId} and ready for the delivery.");
            Thread.Sleep(3000);
        }
    }
}
