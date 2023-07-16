using System;
using System.IO;
using Casino;
using Casino.ClassesAndObjectsGameTwentyOne;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace ClassesAndObjectsGameTwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Atomic Wrangler Hotel and Casino";

            Console.WriteLine("Welcome to the {0}. Let\'s start by telling me your name. ", casinoName);
            string playerName = Console.ReadLine();
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;

            }

            bool validAnswer = false;
            int bank = 0;
            while(!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }

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
                    try
                    {
                        game.Play();
                    }
                    catch (FruadException ex) // Example of a more specific exception, if not it moves on to the general exception.
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex) // General exception.
                    {
                        Console.WriteLine("An error occurred. Please contact your system Administrator.");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return; // When you "return" in a void method (void methods return nothing) it ends the method right there.
                        
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();
        }

        // Datebase Exceptions
        private static void UpdateDbWithException(Exception ex)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwentyOneGame;
                                    Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = "INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();


            }

        }
        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwentyOneGame;Integrated Security=True;Connect  Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";



            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();
            }
            return Exceptions;
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