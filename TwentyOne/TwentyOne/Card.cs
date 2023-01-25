using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        // constructor method name is always the name of the class
        
        //Giving Card class a property 
        public Suit Suit { get; set; }
        public Face Face { get; set; }
    }

    public enum Suit
    {
        Clubs, // value 0, can also assign underlying values
        Diamonds, //1
        Hearts, //2
        Spades // 3
    }

    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack, 
        Queen,
        King,
        Ace
    }
}
