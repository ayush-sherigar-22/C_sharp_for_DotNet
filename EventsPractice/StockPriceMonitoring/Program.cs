using System;
using System.Diagnostics.Contracts;

namespace EventsPractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var stock = new Stock { StockName = "TCS", Price = 1000 };
            var price = new PriceChange();
           var investor = new InvestorApp();
           var riskmanagement = new RiskManagementSystem();

            price.PriceChanged += investor.OnPriceChanged;
            price.PriceChanged += riskmanagement.OnPriceChanged;

            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(2000);
                Console.WriteLine("---------------------------------");
                
                price.PriceUpdate(stock);
                Console.WriteLine("---------------------------------");
            }

        }
    }

}


