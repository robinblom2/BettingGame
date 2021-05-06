using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingGame
{
    class Guy
    {
        public string Name;             // The Name and the Cash fields keep track of the guy's name and how much cash he has in his pocket. 
        public int Cash;

        /// <summary>
        /// Writes my name and the amount of cash i have to the console
        /// </summary>
        public void WriteMyInfo()
        {
            Console.WriteLine($"The player has {Cash} bucks.");             // Sometimes you want to ask an object to perform a task, like printing a description of itself to the console. 
        }

                                                                          

        /// <summary>
        /// Gives some of my cash, removing it from my wallet (or printing a message to the console if i don't have enough cash)
        /// </summary>
        /// <param name="amount">Amount of cash to give</param>
        /// <returns>The amount of cash removed from my wallet, or 0 if i don't have enough cash (or if the amount is invalid)</returns>
        public int GiveCash(int amount)
        {
            if (amount <= 0)                // The method verifies that the amount they're being asked to give is valid. That way you can't ask a guy to receive a negative number, which would cause him to lose cash.
            {
                Console.WriteLine($"{Name} says: {amount} isn't a valid amount!");
                return 0;
            }
            if (amount > Cash)
            {
                Console.WriteLine($"{Name} says: I don't have enough cash to give you {amount}!");
                return 0;
            }
            Cash -= amount;         // The amount specified by the user gets subtracted from the specific Guys Cash-variable.
            return amount;          // The amount then gets returned to where the method was called from. 
        }

        /// <summary>
        /// Recieve some cash, adding it to my wallet (or printing a message to the console if the amount is invalid)
        /// </summary>
        /// <param name="amount">Amount of cash to give</param>
        public void ReceiveCash(int amount)
        {
            if (amount <= 0)                // The method verifies that the amount they're being asked to receive is valid. That way you can't ask a guy to receive a negative number, which would cause him to lose cash.
            {
                Console.WriteLine($"{Name} says: {amount} isn't an amount i'll take!");
            }
            else
            {
                Cash += amount;     // The amount specified by the user gets added to the specific Guys Cash-variable. 
            }
        }
    }
}
