namespace EventsPractice
{
    public class StockPriceChangedEventArgs
    {
        public string  StockName { get; set; }
        public decimal OldPrice { get; set; }
        public decimal NewPrice { get; set; }
        public decimal Percentage { get; set; }
    }

}


