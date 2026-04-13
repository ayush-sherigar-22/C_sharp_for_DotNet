namespace PaymentInterface
{
    public class PaymentProcessor 
    {
        private readonly IPayment _payment;

        public PaymentProcessor(IPayment payment)
        {
            _payment = payment;
        }
        public void ProcessPayment(double amount)
        {
            var finalAmount = _payment.ProcessPayment(amount);

            Console.WriteLine($"Payment Type: {_payment.GetPaymentType()}");
            Console.WriteLine($"Final Amount Paid: {finalAmount}");

            PrintReceipt(amount);
        }
        public virtual void PrintReceipt(double amount)
        {
            Console.WriteLine($"Receipt : Paid {amount}");
        }

    }



}