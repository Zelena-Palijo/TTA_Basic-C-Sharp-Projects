﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        // constructor method name is always the name of the class
        public Card()
        {
            Suit = "Spades";
            Face = "Two";

        }
        //Giving Card class a property 
        public string Suit { get; set; }
        public string Face { get; set; }
    }
}
