using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Polymorphism
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // 1. Calculator Multipy
            
            var calc = new Calculator();
            Console.WriteLine("2 Integer multiplication is : " + calc.Multiply(12, 13));

            Console.WriteLine("3 Integer multiplication is : " + calc.Multiply(12, 13, 7));
            double a = 59; double b = 999;
            Console.WriteLine("2 Double multiplication is : " + calc.Multiply(a, b));
            Console.WriteLine("----------------------");
            
            // 2. Vehicle start
            
            var car = new Car();
            car.Start();

            var bike = new Bike();
            bike.Start();

            var Vehicle = new Vehicle();
            Vehicle.Start();
            Console.WriteLine("----------------------");

            // 3.Shape
           
            Console.WriteLine("----------------------");
            List<Shapes> shape = new List<Shapes>
            {
                new Circle(),
                new Rectangle(),
                new Square()

            };

            foreach (var s in shape)
            {
                s.Draw();

            }
            Console.WriteLine("----------------------");
           
            // 4.Employee

             var ft_emp = new FullTimeEmployee();
            var pt_emp = new PartTimeEmployee();


            var sal_ft = ft_emp.CalculateSalary(8, 5, 4);
            Console.WriteLine("Your salary as Fulltime employee is :" + sal_ft);
            var sal_pt = pt_emp.CalculateSalary(5, 5, 4);
            Console.WriteLine("Your salary as Parttime employee is :" + sal_pt);

            Console.WriteLine("----------------------");

            List<Payment> payments = new List<Payment>
                                        { new CreditCardPayment(),
                                          new UPIPayment(),
                                          new CashPayment()};

            foreach (Payment payment in payments)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine($"Amount to paid  : {payment.ProcessPayment(2000)}");
                Console.WriteLine($"Payment type is : {payment.GetPaymentType()}");
                Console.WriteLine($"Final bill");
                payment.PrintReceipt(2000);
                Console.WriteLine("----------------------");
            }
        }

    }
}
