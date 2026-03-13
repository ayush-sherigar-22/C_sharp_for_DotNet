using System;

namespace Bank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var b = new Bank(1234, "Ayush", 50000);

            b.Desposit(500);
            b.Withdraw(1000);
            b.Display();
        }
    }
}