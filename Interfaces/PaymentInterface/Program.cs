using System;

namespace PaymentInterface
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var creditProcessor = new PaymentProcessor(new CreditCardPayment());
            creditProcessor.ProcessPayment(1000);

            var upiProcessor = new PaymentProcessor(new UPIPayment());
            upiProcessor.ProcessPayment(1000);

            var cashProcessor = new PaymentProcessor(new CashPayment());
            cashProcessor.ProcessPayment(1000);

        }
    }

}
