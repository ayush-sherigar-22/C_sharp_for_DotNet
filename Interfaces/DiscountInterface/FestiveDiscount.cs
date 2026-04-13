namespace Abstraction
{
    public class FestiveDiscount : IDiscount
    {
        public double ApplyDiscount(double price)
        {
            return price > 1000 ? price * 0.8 : price;
        }

        public string GetDiscountType() => "Festive Discount (20%)";
    }
}