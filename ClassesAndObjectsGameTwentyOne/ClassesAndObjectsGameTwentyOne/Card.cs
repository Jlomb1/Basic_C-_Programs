using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsGameTwentyOne
{
     public struct Card // Card class is changed to a "struct". A card is a small value and one you set the value of a card, you dont really want it changing.
    {
        //public Card() // Constructor (if we dont assign any values later these are the default values that are given to it).
        //{
        //    Suit = "Spades";
        //    Face = "Two";
        //}
        // A good way to look at classes & objects are; a class is a cookie cutter and the object would be the actual cookie.
        // By making this property 'public' it means its accessible to other parts of the program.
        public Suit Suit { get; set; } // The card class has a property of data type string called "suit" you can 'get' the property or 'set' the property.
        public Face Face { get; set; } 
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
