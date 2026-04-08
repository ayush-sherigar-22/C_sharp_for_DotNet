namespace Inheritance
{
    public class Person
    {
        public string? name;
        public int age;

    }

    public class Student : Person
    {
        public int marks;

        public Student()
        {

        }

        public Student(int marks)
        {
            this.marks = marks;
        }
    }
}
