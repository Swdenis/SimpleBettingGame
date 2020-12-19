using System;

namespace SimpleBettingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Random randomOdss = new Random();
            double odds = randomOdss.NextDouble();
            Player player = new Player() { Cash = 100, Name = "The player" };
            Console.WriteLine("Good day, player. What is your name?");
            string playerName = Console.ReadLine();
            Console.WriteLine("Welcome " + playerName + "!" + " Are you ready to gamble?" + " The odds are: " +
                odds + ".");
            while (player.Cash > 0)
            {
                player.WriteMyInfo();
            Console.WriteLine("How much money do you want to bet, " + playerName + "?");
            string howMuch = Console.ReadLine();
            


                if (int.TryParse(howMuch, out int amount))
                {
                    int pot = player.GiveCash(amount);
                    pot *= 2;
                    if (pot > 0)
                    {
                        if (random.NextDouble() > odds)
                        {
                            Console.WriteLine("You win " + pot + "!");
                            player.ReceiveCash(pot);
                        }
                        else { Console.WriteLine("Bad luck, you lose."); }
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
            Console.WriteLine("The house always wins.");


        }
        
    }
}
