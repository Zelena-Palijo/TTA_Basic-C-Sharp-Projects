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
                player.Hand = new List<Card>(); //refresh deck
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>(); //refresh dealer hand
            Dealer.Stay = false;
            Dealer.Deck = new Deck(); //refresh deck

            Console.WriteLine("Place your bet!");

            foreach (Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet)
                {
                    return; //not return anything, but end method
                }
                Bets[player] = bet; //Created dictionary Bets, player is key
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
