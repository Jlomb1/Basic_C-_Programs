using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassesAndObjectsGameTwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First()); // We add the first item.
            // We are writing to the console the card that we are about to put into the Deck.
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card); // We print it to the console.
            // Example of using System.IO (i.e logging).
            using (StreamWriter file = new StreamWriter(@"C:\Users\jlomb\Documents\log\TwentyOneLog.txt", true)) 
            {
                file.WriteLine(DateTime.Now); // Example of DateTime when logging. 
                file.WriteLine(card);
            }
            Deck.Cards.RemoveAt(0); // We then remove it.
        } 
    }
}

// Referencing line 17 - Deck is composed of a list of Cards (Cards being one of "Deck"s properties), and First() is a method
// available to a list that takes the first item in that list.