using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Hotel and Casino! First, what is your name?");
            string playerName = Console.ReadLine();
            Console.WriteLine("Great! How much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank); //create new player
                Game game = new TwentyOneGame(); //polymorphism
                game += player;
                player.isActivelyPlaying = true; //while loop later to keep game going if playing
                while(player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
            }
        }

    }
}
