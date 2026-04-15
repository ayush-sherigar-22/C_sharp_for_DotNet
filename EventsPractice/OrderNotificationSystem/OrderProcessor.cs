namespace EventsPractice
{
    public class OrderProcessor
    {
        public delegate void OrderProcessorEventHandler(object source, OrderEventArgs args);
        public event OrderProcessorEventHandler OrderProcessed;

        public void Process(Order order)
        {
            Console.WriteLine("Order is being Processed. You will be notified once the order is processed.");
            Thread.Sleep(3000);

            OnOrderProcessed(order);
        }

        protected virtual void OnOrderProcessed(Order order)
        {

            if(OrderProcessed != null)
            {
                OrderProcessed(this, new OrderEventArgs { Order = order });

            }
        }
    }
}
