using System;
using System.IO;
using Casino;
using Casino.ClassesAndObjectsGameTwentyOne;

namespace ClassesAndObjectsGameTwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Atomic Wrangler Hotel and Casino";

            Console.WriteLine("Welcome to the {0}. Let\'s start by telling me your name. ", casinoName);
            string playerName = Console.ReadLine();

            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid(); // Globaly Unique Identifier 
                using (StreamWriter file = new StreamWriter(@"C:\Users\jlomb\Documents\log\TwentyOneLog.txt", true))
                {
                    file.WriteLine(player.Id); // Example of Guid player.Id data being logged.  
                }
                Game game = new TwentyOneGame();
                game += player;
                player.IsActivelyPlaying = true;

                while (player.IsActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();
        }
    }
}

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

//// Example of a "Struct"-------------------------------
//int number = 5; // right click "int" to see definition.
//// if you change the Card class to "Struct" it makes the console print Eight. If you leave it at "Class" it will print King.
//Card card1 = new Card();
//Card card2 = card1;
//card1.Face = Face.Eight;
//card2.Face = Face.King;
//Console.WriteLine(card1.Face);

//// Example of a Lambda Fuction -----------------------
//// You could write this counter with a foreach OR
//int counter = 0;
//foreach (Card card in deck.Cards)
//{
//    if (card.Face == Face.Ace)
//    {
//        counter++;
//    }
//}
//Console.WriteLine(counter);
//// that same function above could look like this.
//int count = deck.Cards.Count(x => x.Face == Face.Ace);

//List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();
//List<int> numberList = new List<int>() { 1, 2, 3, 545, 453, 23 };
//int sum = numberList.Where(x => x > 20).Sum();
//Console.WriteLine(sum);

// System.IO and adding text to the log -------------
//string text = "Here is some text: ";
//File.WriteAllText("C:\\Users\\jlomb\\Documents\\log\\TwentyOneLog.txt", text); // Remember the "@" helps read the line without the "\".

// Examples of DateTime and TimeSpan for logging -----------
//DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
//DateTime yearOfGraduation = new DateTime(2013, 6, 1, 16, 24, 22);
//TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth;