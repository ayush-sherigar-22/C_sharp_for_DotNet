namespace Inheritance
{
    public class Shape()
    {
        public void Draw()
        {
            Console.WriteLine("Drawing the shape.");
        }
    }

    public class Circle : Shape
    {
        public int radius;
        public Circle() { }
        public Circle(int radius)
        {
            this.radius = radius;
        }
        public void DrawCircle()
        {
            Console.WriteLine("Drawing a Cricle with Radius {0}", radius);
        }
    }


    public class Rectangle : Shape
    {
        public int length;
        public int breadth;
        public Rectangle() { }


        public Rectangle(int length, int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public void DrawRectangle()
        {
            Console.WriteLine("Drawing a Rectangle with Length {0}  and Breadth {1}", length, breadth);
        }
    }

}
