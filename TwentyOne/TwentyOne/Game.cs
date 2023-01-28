using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game //will be a base class or abstract class
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get; set; } //dictionary property of players, bets

        public abstract void Play();
        // indicates any game that inherits from Game will include Play method

        public virtual void ListPlayers() 
            //virtual method in abstract class gets inherited by inheriting class, 
            //but can override it
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
