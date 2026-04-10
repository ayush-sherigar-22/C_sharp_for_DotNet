namespace Abstraction
{
    public class FestiveDiscount : Discount
    {
        public FestiveDiscount(double price) : base(price) { }
        

        public override double ApplyDiscount(double price)
        {
            if(price > 1000)
            {
                 return(price -= (price * 0.2));
            }
            else { return(price);}
            
           
        }

    }
}







