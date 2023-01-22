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
            //Cards = new List<Card>();
            //Card cardOne = new Card();
            //cardOne.Face = "Two";
            //cardOne.Suit = "Hearts";
            //Cards.Add(cardOne);

            //easier way using nested for/each loop instead of writing it out
            Cards = new List<Card>();
            //list of all possible suits
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string face in Faces)
            {
                foreach(string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }

        }

        public List<Card> Cards { get; set; }


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
