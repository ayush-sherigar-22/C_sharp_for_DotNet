namespace Abstraction
{
    public class NoDiscount : Discount
    {
        public NoDiscount(double price) : base(price) { }
        

        public override double ApplyDiscount(double price)
        {
            return price;
        }

    }
}







