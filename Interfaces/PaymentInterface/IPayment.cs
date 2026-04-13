namespace PaymentInterface
{
    public interface IPayment
    {
        double ProcessPayment(double amount);
        string GetPaymentType();
    }



}