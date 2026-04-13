namespace Abstraction
{
    public class DiscountCalculator
    {
        private readonly IDiscount _discount;

        public DiscountCalculator(IDiscount discount)
        {
            _discount = discount ?? throw new ArgumentNullException(nameof(discount));
        }

        public void CalculateFinalPrice(double originalPrice)
        {
            double finalPrice = _discount.ApplyDiscount(originalPrice);
            PrintReceipt(originalPrice, finalPrice);
        }

        private void PrintReceipt(double originalPrice, double finalPrice)
        {
            Console.WriteLine($"Discount Type : {_discount.GetDiscountType()}");
            Console.WriteLine($"Original Price: {originalPrice}");
            Console.WriteLine($"Final Price   : {Math.Max(0, finalPrice)}");
        }
    }
}