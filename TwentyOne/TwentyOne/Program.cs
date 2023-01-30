using System;
using Casino;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main()
        {
            const string casinoName = "Grand Hotel and Casino";
            Console.WriteLine("Welcome to the {0}! First, what is your name?", casinoName);
            string playerName = Console.ReadLine();

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("Great! How much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank); //create new player
                Game game = new TwentyOneGame(); //polymorphism
                game += player;
                player.IsActivelyPlaying = true; //while loop later to keep game going if playing
                while(player.IsActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException)
                    {
                        Console.WriteLine("Security! Kick this person out.");
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An error occurred. Please contact your system administrator.");
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();
            //All of the above is the entirety of the main method
        }

    }
}
