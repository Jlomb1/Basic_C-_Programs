using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsGameTwentyOne
{
    public class Deck
    {
        public Deck() // Constructor (remember this assigns values to an object immedietly upon creation). 
        {
            // This is essentially creating a deck of 52 cards by using the foreach loop 
            // instead of having to manually add each individual card every time for the program. 
            Cards = new List<Card>();
            List<string> Suits = new List<string>() { "clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven", "Eight",
                "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }

        }
        public List<Card> Cards { get; set; }  
    }
}
