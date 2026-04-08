using EncapsulationPractice;
using System;
using System.Runtime;
using System.Runtime.CompilerServices;

namespace Encapsultion
{

    public class Program
    {
        public static void Main(string[] args)
        {
            // 1. Student Age
            var stud = new Student();
            stud.Age = 10;


            // 2. Bank Balance
            var bal = new BankAccount();
            bal.Deposit(5000);
            bal.Withdraw(123.32f);
            bal.Withdraw(60);
           

            // 3. Employee Details
            var emp = new EmployeeSalary(123, "ABC", 45678);
            emp.DisplayDetails();
            emp.IncreaseSalary(90000);
            emp.DeductSalary(45000);
            emp.ApplyBonus(10);
            emp.DisplayDetails();


            // 4. Product
            var prod = new Product("Keyboard", 450);
            prod.DisplayDetails();
            prod.SetDiscount(10);
            var finalPrice = prod.FinalPrice();
            Console.WriteLine("Final Price is : "+finalPrice); 


            // 5. Employee Registration
            var user = new UserRegistrationSystem("Ayush", "123456");
            Console.WriteLine(user.CheckPassword("123456")); // true
            user.ChangePassword("newpass123");
            user.DisplayUser();
        }
    }
}








