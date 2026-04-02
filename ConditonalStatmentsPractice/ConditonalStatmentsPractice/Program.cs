using System;
using System.Collections.Concurrent;
using System.Runtime.Intrinsics.Arm;
using System.Xml;

namespace ContinalStatement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //IfElseGuess();
            //WhileGuess();
            //DieRoll();
            var subs = new SubscriptionExpiry();
            subs.CheckSubscription();
        }

        public static void IfElseGuess()
        {
            /* 1. Random number guessing game using if-else*/

            var number = new Random().Next(1, 10);
            Console.Write("Guess the number : ");
            var input = Console.ReadLine();
            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Invalid input");
            }
            if (number == num)
            {
                Console.WriteLine("Right choice");
            }
            else
            {
                Console.WriteLine("Wrong guess !");
            }
        }

        public static void WhileGuess()
        {

            /* 2.Random number guess with 5 choice*/
            var number = new Random().Next(1, 10);
            var counter = 1;
            

            while (counter < 5)
            {
                Console.Write("Guess the number : ");
                var input = Console.ReadLine();
                if (!int.TryParse(input, out int num))
                {
                    Console.WriteLine("Invalid input");
                }
                if (number == num)
                {
                    Console.WriteLine("Right choice");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong guess !");
                    counter++;
                    if (counter == 5)
                    {
                        Console.WriteLine("The number was {0} : ", number);
                    }
                       
                }
            }

        }


        public static void DieRoll()
        {
            Console.WriteLine("Enter a total that you will cross after 3 rolls");
            var result = Console.ReadLine();
            if (!int.TryParse(result, out int num))
            {
                Console.WriteLine("Invalid Input");
            }

            var roll1 = new Random().Next(1, 7);
            var roll2 = new Random().Next(1, 7);
            var roll3 = new Random().Next(1, 7);

            Console.WriteLine("Your 3 rolls are : {0}, {1}, {2}",roll1, roll2, roll3);
            Thread.Sleep(1000);

            var total = roll1 + roll2 + roll3;

            if ((roll1 == roll2) && (roll2 == roll3))
            {
                total += 6;
                Console.WriteLine("You Rolled a Triple. Your Total is : {0} ", total);

                if (total > num)
                {
                    Console.WriteLine("Congratulations you win");
                }
                else { Console.WriteLine("You Lose Game end!"); }
            }


            else if((roll1 ==  roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
                total += 2;
                Console.WriteLine("You rolled a double . Total is : = {0} ", total);
                if (total > num)
                {
                    Console.WriteLine("Congratulations you win");
                }
                else { Console.WriteLine("You Lose Game end!"); }
            }

            else if (total > num)
            {
                Console.WriteLine("Congratulations you win");
            }

            else { Console.WriteLine("You Lose Game end!"); }

            
        

        }
    }

    public class SubscriptionExpiry
    {
      public void CheckSubscription()
      {
            Random random = new Random();
            int daysUntilExpiration = random.Next(20);
            int discountPercentage;


            if (daysUntilExpiration == 0)
            {
                Console.WriteLine("Your subscription has expired.");
            }

            else if (daysUntilExpiration == 1)
            {
                discountPercentage = 20;
                Console.WriteLine("Your subscription expires within a day!\nRenew now and save {0}%!", discountPercentage);
            }

            else if ((1 < daysUntilExpiration) && (daysUntilExpiration <= 5))
            {
                discountPercentage = 10;
                Console.WriteLine("Your subscription expires in {0} days.\nRenew now and save {1}% !", daysUntilExpiration, discountPercentage);
            }


            else if ( (daysUntilExpiration > 5) && (daysUntilExpiration <= 10) )
            {
                Console.WriteLine("Your subscription will expire soon in {0}.\nRenew now!", daysUntilExpiration);
            }


           

        }
    }

    
}