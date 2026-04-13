using System;
using System.Collections.Generic;

namespace Abstraction
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double amount = 5000;

            var discounts = new List<IDiscount>
            {
                new FestiveDiscount(),
                new MembershipDiscount(),
                new NoDiscount()
            };

            foreach (var discount in discounts)
            {
                var calculator = new DiscountCalculator(discount);
                calculator.CalculateFinalPrice(amount);
                Console.WriteLine("----------------------");
            }
        }
    }
}