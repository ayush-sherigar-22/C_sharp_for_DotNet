namespace PaymentInterface
{
    public class UPIPayment : IPayment
    {
        public string GetPaymentType()
        {
            return "UPI";
        }

        public double ProcessPayment(double amount)
        {
            if (amount >= 1000) return amount - 50;
            return amount;
        }
        
    }



}