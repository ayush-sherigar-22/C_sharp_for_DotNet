namespace Bank
{
    public class Bank
    {
        private  int BankAccountNumber { get; set; }
        private  string AccountHoldersName { get; set; }
        private float BankBalance { get; set; }

        public Bank(int accountNumber, string name, float balance)
        {
            BankAccountNumber = accountNumber;
            AccountHoldersName = name;
            BankBalance = balance;
        }

        public float Desposit(float value)
        {
            BankBalance += value;
            return BankBalance;
        }

        public float Withdraw(float value)
        {
            BankBalance -= value;
            return BankBalance;
        }

        public void Display()
        {
            Console.WriteLine("Account Holders Name : " + AccountHoldersName);
            Console.WriteLine("Account Number : " + BankAccountNumber);
            Console.WriteLine("Account Balance : " + BankBalance);
        }
    }
}