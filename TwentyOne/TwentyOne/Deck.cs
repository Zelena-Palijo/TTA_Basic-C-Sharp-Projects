using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        //add constructor here
        public Deck()
        {
            //easier way using nested for/each loop instead of writing it out
            Cards = new List<Card>();
            
            //Building deck method from scratch
            //Loops through 52x, create new card 52 times
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i; // casting to Face, j
                    card.Suit = (Suit)j;
                    Cards.Add(card);

                }
            }

        }

        public List<Card> Cards { get; set; }


        //CREATED A CLASS METHOD
        //out variable is timesShuffled >> removed
        //removed static, so the deck belongs to the object created there
        public void Shuffle(int times = 1) //since operating on a deck, got rid of Deck deck
        {
            //timesShuffled = 0;
            //every time you loop, add to timesShuffled
            for (int i = 0; i < times; i++)
            {
                //create a temporary list where the items will go
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0) // was deck.Cards.Count but since operating on these cards
                    //can just remove deck
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }

            //return deck; // no need to return anything since doing internally
        }
    }
}
