namespace PaymentInterface
{
    public class CreditCardPayment : IPayment
    {
        public string GetPaymentType()
        {
            return "Credit Card";
        }

        public  double ProcessPayment(double amount)
        {
            return amount + (amount * 0.02);
        }

      
    }



}