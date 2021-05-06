using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double odds = .75;

            Guy player = new Guy() { Name = "The Player", Cash = 100 };

            Console.WriteLine($"Welcome to the Casino. The odds are: {odds}");

            while (player.Cash > 0)
            {
                player.WriteMyInfo();                                       // For every iteration of the loop we print the players current amout of cash in the wallet. 

                Console.Write("How much do you want to bet: ");
                string howMuch = Console.ReadLine();

                if (int.TryParse(howMuch, out int amount))
                {
                    int pot = player.GiveCash(amount) * 2;                  // If the convertion by the TryParse is successfull, the amount gets subtracted from the players wallet. It then gets multiplied by two, because it's a double-or-nothing bet, and then it gets put in the pot. 

                    if (pot > 0)                                            // If the pot is bigger then 0 (if the player added anything to the pot)
                    {
                        if (random.NextDouble() > odds)                     // If the random number (between 0.0 - 1.0) is bigger than the odds (0.75) 
                        {
                            int winnings = pot;                             // The player has won! And receives the winnings by a call to the ReceiveCash-method. 
                            Console.WriteLine($"You win {winnings}");
                            player.ReceiveCash(winnings);
                        }
                        else                                                // Else, if the odds is larger than the random number...
                        {
                            Console.WriteLine("Bad luck, you loose.");      // The player has lost!
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");      // This line gets printed if the convertion by the TryParse-method was unsuccessfull.
                }
            }
            Console.WriteLine("The house always wins!");                    // This line gets printed when the program exits the loop, with other words, when the player has 0 cash left. 



        }
    }
}
