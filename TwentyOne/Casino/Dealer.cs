using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            // First is a built-in method that takes the first of the list
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C:\Users\Owner\Desktop\log.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            }
            Deck.Cards.RemoveAt(0); 
            //Add first item, print to console, then remove it from deck
        }
    }
}
