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
            deck.Cards = new List<Card>(); // instatiate data type list card


            Card cardOne = new Card(); // instantiate the object
            // give the properties some values
            cardOne.Face = "Queen";
            cardOne.Suit = "Spades";

            deck.Cards.Add(cardOne);

            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
            Console.ReadLine();

        }
    }
}
