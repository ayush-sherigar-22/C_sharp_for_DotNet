namespace Polymorphism
{
    public class Shapes
    {
        public virtual void Draw()
        {
            Console.WriteLine("Draw a Shape");
        }
    }
    public class Circle : Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle.");
        }

    }

    public class Rectangle : Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
    }
    public class Square : Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Square");
        }
    }


}