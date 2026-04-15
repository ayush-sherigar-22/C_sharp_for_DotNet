namespace EventsPractice
{
    public class InvestorApp
    {
        public void OnPriceChanged(object source, StockPriceChangedEventArgs e)
        {
            Console.WriteLine($"The stock {e.StockName} price has changed.");
            Console.WriteLine($"Old Price : {e.OldPrice}");
            Console.WriteLine($"New Price : {e.NewPrice}");
            Console.WriteLine($"Percentage difference is : {e.Percentage}%");
        }
    }

}


