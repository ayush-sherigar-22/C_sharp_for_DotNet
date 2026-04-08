namespace Inheritance
{
    public class Animal
    {
        public void MakeSound()
        {
            Console.WriteLine("The Animal Makes Sound");
        }

    }

    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Bark");
        }
    }
    
}


  
    