namespace Polymorphism
{
    public class CreditCardPayment : Payment
    {
        public override string GetPaymentType()
        {
            return "Credit Card";
        }

        public override double ProcessPayment(double amount)
        {
            return amount + (amount * 0.02);
        }

        public override void PrintReceipt(double amount)
        {
            Console.WriteLine($"Paid {amount} using Credit Card (2% fee applied)");
        }
    }
}
