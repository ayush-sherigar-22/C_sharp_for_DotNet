using System;
using System.Threading.Channels;

namespace LoopStatements
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //SumofNumbers();
            //EvenCount();
            //ReverseNum();
            //Login();
            Calculator();

        }


        public static void SumofNumbers()
        {

            // Print the sum of first N natural numbers

            Console.Write("Enter a limit");
            var limit = Console.ReadLine();
            var result = 0;
            if (int.TryParse(limit, out int num))
            {
                for (int i = 0; i <= num; i++)
                {
                    result += i;
                }
                Console.WriteLine("Result of sum is :  " + result);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        public static void EvenCount()
        {
            // Given an array, count how many numbers are even

            int[] arr = new int[5];
            var even = 0;
            Console.WriteLine("Enter an array");
            for (int i= 0;  i < 5; i++)
            {  
                arr[i] = int.Parse(Console.ReadLine());
            }

            foreach(var n in arr)
            {
                if(n%2 == 0)
                {
      
                    even += 1;
                }
            }
            Console.WriteLine("Number of Even numbers in given array is {0}", even);
        }


        public static void ReverseNum()
        {
            // Reverse a number

            Console.WriteLine("Enter a number");
            var input = Console.ReadLine();
            if(!int.TryParse(input, out int num))
            {
                Console.WriteLine("Invalid input");
            }
            var last = num;
            var result = " ";
            while (last >= 1)
            {
               
               last = num % 10;
               if (last == 0)
               {
                    break;
               }
               num = num / 10;
               result += last;
               Console.WriteLine(last);
               
            }
            
        }

        public static void Login()
        {
            //  Create a simple login system


            var password = "Admin@1234";
            bool flag = true;
            do
            {
                Console.WriteLine("Enter Password");
                var input = Console.ReadLine();
                if (input == password)
                {
                    flag = false;
                }
                else Console.WriteLine("Wrong Password, Try Again.");
            } while (flag);
            Console.WriteLine("Logged in Succesfully");
        }
    
        public static void Calculator()
        {
            Console.WriteLine("Enter Your Choice:  \n1.Addition\n2.Substract\n3.Multiplication\n4.Division");
            var input = int.Parse(Console.ReadLine());
            while (true) {
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Enter one number : ");
                        var num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter another number : ");
                        var num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Addition is :" + (num1 + num2));
                        break;

                    case 2:
                        Console.WriteLine("Enter one number : ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter another number : ");
                        num2 = int.Parse(Console.ReadLine());
                        if (num1 > num2)
                        {
                            Console.WriteLine("Subtraction is: " + (num1 - num2));
                        }
                        else
                        {
                            Console.WriteLine("Subtraction is: " + (num2 - num1));
                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter one number : ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter another number : ");
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Multiplication is :" + (num1 * num2));
                        break;

                    case 4:
                        Console.WriteLine("Enter one number : ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter another number : ");
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Division is :" + (num1 / num2));
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                    }
                }
        }
    }

}