namespace Polymorphism
{
    public class CashPayment : Payment
    {
        public override string GetPaymentType()
        {
            return "Cash";
        }

        public override double ProcessPayment(double amount)
        {

            return amount - (amount * 0.05); ;
        }
        public override void PrintReceipt(double amount)
        {
            Console.WriteLine($"Paid {amount} using  Cash (5% discount applied)");
        }

    }
}
