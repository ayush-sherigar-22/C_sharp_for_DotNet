namespace Polymorphism
{
    public abstract class Payment
    {
        public abstract double ProcessPayment(double amount);
        public abstract string GetPaymentType();
        public virtual void PrintReceipt(double amount)
        {
            Console.WriteLine($"Paid {amount}");
        }

    }
}
