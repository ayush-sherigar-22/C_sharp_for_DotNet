namespace Polymorphism
{
    public class UPIPayment : Payment
    {
        public override string GetPaymentType()
        {
            return "UPI";
        }

        public override double ProcessPayment(double amount)
        {
            if (amount > 1000) return amount - 50;
            return amount;
        }
        public override void PrintReceipt(double amount)
        {
            Console.WriteLine($"Paid {amount} using UPI Card (50 cashback applied)");
        }
    }
}
