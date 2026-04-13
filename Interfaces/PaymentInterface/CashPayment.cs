namespace PaymentInterface
{
    public class CashPayment : IPayment
    {
        public  string GetPaymentType()
        {
            return "Cash";
        }

        public double ProcessPayment(double amount)
        {

            return amount - (amount * 0.05); ;
        }
        

    }



}