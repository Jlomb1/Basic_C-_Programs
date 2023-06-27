using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsGameTwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            // Deck is composed of a list of Cards (Cards being one of "Deck"s properties), and First() is a method
            // available to a list that takes the first item in that list.
            Hand.Add(Deck.Cards.First()); // We add the first item.
            // We are writing to the console the card that we are about to put into the Deck.
            Console.WriteLine(Deck.Cards.First().ToString() + "\n"); // We print it to the console.
            Deck.Cards.RemoveAt(0); // We then remove it.
        } 
    }
}
