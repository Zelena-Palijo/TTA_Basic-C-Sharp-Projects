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
            Deck deck = new Deck(); //instatiated an object named deck object of Deck
            deck.Shuffle();
            //ex, deck.Shuffle(3) >> calls method on itself
            //int timesShuffled = 0;
            //deck = Shuffle(deck, out timesShuffled, 3);
            //^Changed so that it appears cleaner, calls edited method Shuffle()
            
            
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            //Console.WriteLine("Times shuffled {0}", timesShuffled);
            Console.ReadLine();

        }

       

        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
