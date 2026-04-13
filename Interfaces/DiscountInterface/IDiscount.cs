namespace Abstraction
{
    public interface IDiscount
    {
        double ApplyDiscount(double amount);
        string GetDiscountType();
    }
}