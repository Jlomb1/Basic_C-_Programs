using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsGameTwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck = Shuffle(deck); // This is something to assign the returned deck to, if you comment this out it will be in order.

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        // Reminder "static" is in place so we dont have to create an object program before calling this method.
        public static Deck Shuffle(Deck deck)
        {
            // Creating a temporary list of cards where we store our shuffled items. 
            List<Card> TempList = new List<Card>();
            // "Random" is a built in class through the .NET Framwork
            Random random = new Random();

            // This is the method.
            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count); //0 to 52.
                TempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex); //RemoveAt is a function of the "list" method.
            }
            deck.Cards = TempList;
            return deck;
        }
    }
}
