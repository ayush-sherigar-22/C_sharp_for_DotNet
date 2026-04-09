namespace Polymorphism
{
    public class Calculator
    {
        public virtual int Multiply(int x, int y)
        {
            return x*y;
        }

        public int Multiply(int x, int y, int z)
        {
            return  x*y*z;
        }

        public  double Multiply(double x, double y)
        {
            return x*y;
        }
    }

   
}