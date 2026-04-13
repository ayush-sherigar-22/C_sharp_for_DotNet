namespace Abstraction
{
    public class NoDiscount : IDiscount
    {
        public double ApplyDiscount(double price) => price;

        public string GetDiscountType() => "No Discount";
    }
}