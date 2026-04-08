using System;
using System.Threading.Channels;

namespace Inheritance
{

    public class Program
    {
        public static void Main(string[] args) 
        {

            // 1. Animal
            Console.WriteLine("* Animal Class Dog *\n ");
            var dog = new Dog();
            dog.MakeSound();
            dog.Bark();

            var animal = new Animal();
            animal.MakeSound();
            //animal.Bark(); cant do this

            // 2. Person Student
            Console.WriteLine("\n* Person Student Class *\n");
            var stud = new Student();
            stud.name = "Raj";
            stud.age = 23;
            stud.marks = 67;

            Console.WriteLine($" \n Student Name is : {stud.name}. \n Student age is {stud.age} \n Student has got {stud.marks} marks;");


            // 3. Shapes
            Console.WriteLine("\n * Shapes Class * \n");
            var circle = new Circle();
            circle.radius = 10;
            circle.Draw();
            circle.DrawCircle();


            var rectangle = new Rectangle(12, 3);
            rectangle.Draw();
            rectangle.DrawRectangle();

            var shape = new Shape();
            shape.Draw();


            // 4. Appliance 
            Console.WriteLine("\n * Appliance Class * \n");
            var wash = new WashingMachine();
            var dryer = new ClotherDryer();

            wash.WashClothes();
            dryer.DryClothes();


            // 5. Bank Account
            Console.WriteLine("\n* Bank Account Class *\n");
            var acc = new CurrentAccount();
            acc.Deposit(5000);
            acc.DisplayBalance();
            acc.Withdraw(600);
            acc.DisplayBalance();

        }
    }

    
    
}
