﻿using System;
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
            Card cardOne = new Card(); // instantiate the object
            //give the properties some values
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";

            Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
            Console.ReadLine();

        }
    }
}
