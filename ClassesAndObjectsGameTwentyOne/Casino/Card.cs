using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
     public struct Card 
    {
        // The card class has a property of data type string called "suit" you can 'get' the property or 'set' the property.
        public Suit Suit { get; set; } 
        public Face Face { get; set; }

        // When we do card.ToString() it prints to the console for example a king of hearts or jack of spades (custom ToString() method).
        public override string ToString() 
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
    }
    //// Enums -----------------------
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
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

// Card class is changed to a "struct". A card is a small value and one you set the value of a card, you dont really want it changing.
//public Card() // Constructor (if we dont assign any values later these are the default values that are given to it).
//{
//    Suit = "Spades";
//    Face = "Two";
//}
// A good way to look at classes & objects are; a class is a cookie cutter and the object would be the actual cookie.
// By making this property 'public' it means its accessible to other parts of the program.