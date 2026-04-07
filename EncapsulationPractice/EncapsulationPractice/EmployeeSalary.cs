namespace Encapsultion
{
    public class EmployeeSalary
    {
        private readonly int _id;
        private string _name;
        private float _salary;


        public EmployeeSalary(int id, string name, float sal)
        {
            _id = id;

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Invalid Name");
            }
            _name = name;
            SetSalary(sal);
        }
       
      private void SetSalary(float amnt)
       {
            if (amnt < 10000)
            {
                throw new InvalidOperationException("Invalid Salary");
            }
            _salary = amnt;
       }
        public float IncreaseSalary(float amount)
        {
            if (amount <= 0)
            {
                throw new InvalidOperationException("Invalid amount provided");

            }
            return _salary += amount;
        }

        public float ApplyBonus(float bonus)
        {
            if (bonus <= 0 || bonus > 100)
            {
                throw new InvalidOperationException("Invalid percentage of bonus");
            }
            bonus = _salary * bonus / 100;
            _salary += bonus;
            return _salary;

        }

        public float DeductSalary(float amount)
        {
            if (amount <= 0 ||  amount > _salary)
            {
                throw new InvalidOperationException("Invalid amount provided");

            }
            _salary -= amount;
            return _salary;
        }

          public void DisplayDetails()
        {
            Console.WriteLine($"Employee ID : {_id} ");
            Console.WriteLine($"Employee name is: {_name}");
            Console.WriteLine($"Employee salary is: {_salary}" );
        }
    }
}
           

   
