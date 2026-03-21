
using System.Collections;


namespace StackExercise
{
    public class Program
    {
        public static void Main(string[] args) {


            var stack = new Stack();

            while (true) {

                Console.WriteLine("Chose one Option \n1.Push \n2.Pop \n3.Clear  : ");
                var option = Console.ReadLine();
                switch (int.Parse(option))
                {
                    case 1:
                        Console.WriteLine("Enter object to push");
                        var item = Console.ReadLine();
                        stack.Push(item);
                        continue;

                    case 2:
                        var obj = stack.Pop();
                        Console.WriteLine($"Popped object is :{obj}");
                        continue;

                    case 3:
                        stack.Clear();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        continue;
                }
            }
            
         }
    }
}