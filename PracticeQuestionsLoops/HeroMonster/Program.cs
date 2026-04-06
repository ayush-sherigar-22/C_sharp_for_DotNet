using System;

namespace HeroMonster
{

    public class Program
    {
        public static void Main(string[] args) {

            var heroHealth = 10;
            var monsterHealth = 10;
            
            var attackhealth=0;
            do
            {
            
                    attackhealth = new Random().Next(1, monsterHealth);
                    monsterHealth -= attackhealth;
                    Thread.Sleep(1000);
                    Console.WriteLine("Monster was attacked and lost {0} health and now has {1} health. ", attackhealth, monsterHealth);
                   
                
                if(monsterHealth>=0)
                {
                    attackhealth = new Random().Next(1, heroHealth);
                    heroHealth -= attackhealth;
                    Thread.Sleep(1000);
                    Console.WriteLine("Hero was attacked and lost {0} health and now has {1} health. ", attackhealth, heroHealth);
      
                }



            }while (monsterHealth != 0 && heroHealth != 0);

           Console.WriteLine(monsterHealth>heroHealth? "Monster Wins!":"Hero Wins!");
           
        }
    }


}