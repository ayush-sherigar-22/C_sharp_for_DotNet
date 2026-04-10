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
}







