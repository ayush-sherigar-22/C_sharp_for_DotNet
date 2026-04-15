namespace EventsPractice
{
    public class PriceChange
    {
        public delegate void StockPriceEventHandler(object source, StockPriceChangedEventArgs temp);
        public event StockPriceEventHandler PriceChanged;
        
        public void PriceUpdate(Stock stock)
        {
            var random = new Random();
            var oldPrice = (int)stock.Price;
            var newPrice = random.Next(oldPrice, oldPrice + 100);
            stock.Price = newPrice;
            var percentageDifference = ( (stock.Price - oldPrice) / oldPrice) * 100;

            if (percentageDifference > 5)
            {
                Console.WriteLine($"Price for {stock.StockName} is {stock.Price}");
                OnPriceChanged(stock, oldPrice, newPrice, percentageDifference);
            }
            else
            {
                Console.WriteLine($"The stock {stock.StockName}.");
                Console.WriteLine($"Old Price : {oldPrice}");
                Console.WriteLine($"New Price : {newPrice}");
                Console.WriteLine("Minor change - no alert triggered");

            }
           
        }

        protected virtual void OnPriceChanged(Stock stock, decimal oldPrice, decimal newPrice, decimal percentageDifference )
        {
            if (PriceChanged != null)
            {
                PriceChanged(this, new StockPriceChangedEventArgs 
                { 
                    StockName = stock.StockName, 
                    OldPrice = oldPrice, 
                    NewPrice =newPrice,
                    Percentage = percentageDifference
                });
            }
        }

    }

}


