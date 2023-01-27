using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway  //TwentyOneGame inherits from Game and IWalkAway
    {
        public override void Play()
        {
            //instantiate a dealer
            
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
