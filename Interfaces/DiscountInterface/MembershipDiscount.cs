namespace Abstraction
{
    public class MembershipDiscount : IDiscount
    {
        public double ApplyDiscount(double price)
        {
            return price > 2000 ? price - 500 : price;
        }

        public string GetDiscountType() => "Membership Discount (₹500)";
    }
}