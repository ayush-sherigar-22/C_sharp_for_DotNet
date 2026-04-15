namespace EventsPractice
{
    public class RiskManagementSystem
    {
        public void OnPriceChanged(object source,StockPriceChangedEventArgs e)
        {
            Console.WriteLine($"Warning ! : {e.StockName} price is changing. High volatility dectected.");
        }
    }

}


