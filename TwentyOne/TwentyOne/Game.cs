using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game //will be a base class or abstract class
    {
        private List<Player> _players = new List<Player>(); //make so never null
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();


        public List<Player> Players { get { return _players; } set { _players = value; } } 
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } } //dictionary property of players, bets

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
