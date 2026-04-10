namespace Abstraction
{
    public class MembershipDiscount : Discount
    {
        public MembershipDiscount(double price) : base(price) { }
        

        public override double ApplyDiscount(double price)
        {
            if (price> 2000)
            {
               return (price -= 500);
            }
            else { return price; }
        }

    }
}







