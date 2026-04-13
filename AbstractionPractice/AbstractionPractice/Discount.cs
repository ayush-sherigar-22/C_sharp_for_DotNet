namespace Abstraction
{
    public abstract class Discount
    {
        protected double price;
        protected Discount(double price)
        {
            if (price <= 0)
            {
                throw new ArgumentNullException("Invalid Amount");
            }
            this.price = price;
        }

        public abstract double ApplyDiscount(double price);
        public void FinalPrice(double finalPrice)
        {
            if (finalPrice < 0)
                finalPrice = 0;

            Console.WriteLine($"Final price after {this.GetType().Name}: {finalPrice}");
        }

       
    }

    public class FestiveDiscount : Discount
    {
        public FestiveDiscount(double price) : base(price) { }


        public override double ApplyDiscount(double price)
        {
            if (price > 1000)
            {
                return (price -= (price * 0.2));
            }
            else { return (price); }


        }

    }
    public class MembershipDiscount : Discount
    {
        public MembershipDiscount(double price) : base(price) { }


        public override double ApplyDiscount(double price)
        {
            if (price > 2000)
            {
                return (price -= 500);
            }
            else { return price; }
        }

    }

    public class NoDiscount : Discount
    {
        public NoDiscount(double price) : base(price) { }


        public override double ApplyDiscount(double price)
        {
            return price;
        }

    }

}







