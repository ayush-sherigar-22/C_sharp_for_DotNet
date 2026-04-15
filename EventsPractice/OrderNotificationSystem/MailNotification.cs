namespace EventsPractice
{
    public class MailNotification

    {
        public void OnOrderProcessed(object source, OrderEventArgs args)
        {
            Console.WriteLine($"[Mail Notification]: Order is processed for Order ID {args.Order.OrderId} and ready for the delivery.");
            Thread.Sleep(3000);
        }
    }
}
