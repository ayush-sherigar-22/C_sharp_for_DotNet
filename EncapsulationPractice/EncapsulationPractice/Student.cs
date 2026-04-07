namespace Encapsultion
{
    public class Student
    {
        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value <= 5 || value >= 100)
                {
                    throw new ArgumentException("Invalid Age");          
                }

                Console.WriteLine("Valid Age.");
                _age = value;
            }
        }
    }
}