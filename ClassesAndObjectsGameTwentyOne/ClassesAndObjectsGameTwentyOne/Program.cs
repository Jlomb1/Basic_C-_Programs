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
            //List<Game> games = new List<Game>(); // List of games using polymorphisn
            //Game game = new TwentyOneGame(); // Polymorphism - one object (TwentyOneGame) can morph into another higher order object (inherit) Game.
            //games.Add(game); // How to create a list of games that encompass all of our games even though they are different data types.

            // In the abstract class you can have the abstract methods which dont have implementation, but then theres virtual methods which 
            // do have implementation, so you can put in some default implementation, but that can be overridden or part of it can be overridden
            // or add, remove, etc. See below as an example utilizing the Game abstract class and the TwentyOneGame class.

            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Jesse", "Bill", "Bob" };
            //game.ListPlayers();
            //Console.ReadLine();

            //// Operator Overloading ---------------
            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Jesse";
            //game += player;
            //game -= player;

            //// Enum example --------------------------------------
            //Card card = new Card();
            //card.Suit = Suit.Clubs;
            //int underlyingValue = Convert.ToInt32(Suit.Diamonds);
            //Console.WriteLine(underlyingValue);

            Deck deck = new Deck();
            deck.Shuffle(3); // This is something to assign the returned deck to, if you comment this out it will be in order.
                             // "3" in Shuffle is shuffling 3 times.

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
            
            //// Enums ----------------------------------
            //DaysOfTheWeek day = DaysOfTheWeek.Friday;
            //ConsoleColor color = ConsoleColor.DarkRed;
        }
        //public enum DaysOfTheWeek
        //{
        //    Monday,
        //    Tuesday,
        //    Wesnesday,
        //    Thursday,
        //    Friday,
        //    Saturday,
        //    Sunday
        //}
    }
}
