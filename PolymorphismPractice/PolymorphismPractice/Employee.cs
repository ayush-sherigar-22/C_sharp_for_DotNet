namespace Polymorphism
{
    public abstract class Employee
    {
        public abstract double CalculateSalary(int hours, int days, int weeks);
    }

    public class FullTimeEmployee : Employee
    {
        public override double CalculateSalary(int hours, int days, int weeks)
        {
            return (hours * days * weeks * 450);

        }
    }

    public class PartTimeEmployee : Employee
    {
        public override double CalculateSalary(int hours, int days, int weeks)
        {
            return (hours * days * weeks * 250);

        }
    }

}