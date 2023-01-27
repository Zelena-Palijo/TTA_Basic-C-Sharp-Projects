using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway  //TwentyOneGame inherits from Game and IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }

        public override void Play() //for all players
        {
            Dealer = new TwentyOneDealer(); //instantiate a dealer
            foreach (Player player in Players)
            {

            }
        }

        public override void ListPlayers()
        {
            Console.WriteLine("21 Players: ");
            base.ListPlayers();
        }

        public void WalkAWay(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
