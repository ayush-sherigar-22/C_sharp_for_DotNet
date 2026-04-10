namespace Inheritance
{
    public class BankAccount
    {
        protected double balance;

        public BankAccount()
        {
            Console.WriteLine("this is parent");
        }
       

        public void Deposit(double amount)
        {
            if (amount <=  0)
            {
                throw new  ArgumentException("Invalid Amount");
            }

            balance += amount;
            Console.WriteLine("Successful Transaction");
        }

        public void DisplayBalance()
        {

            Console.WriteLine($"Current account has balance {balance}");
        }
     
        
    }

    public class CurrentAccount : BankAccount
    {

        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                throw new ArgumentException("Insufficiuent Balance");
            }
            else if (amount <= 0)
            {
                throw new ArgumentException("Invalid Amount");
            }

            balance -= amount;
            Console.WriteLine($"Successful Transaction.");

        }
    }

}
