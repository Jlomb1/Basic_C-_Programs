using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsGameTwentyOne
{   // the ":" is how you inherit. Also "Game" has an abstract method called Play() which you have to implement.
    public class TwentyOneGame : Game, IWalkAway 
    {
        public override void Play() // Use the "override" keyword to implement the abstract method in "Game" called "Play()". 
        {
            throw new NotImplementedException(); // If called it throws this error. 
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players: ");

            // This was automatically populated while creating the ListPlayers() because its the equal to the foreach method in Games abstract class.
            base.ListPlayers();
        }
        // We've satisfied the "IWalkAway" interface requirements because it matches the return type inside the interface.
        public void WalkAway(Player player) // Has to be a void.
        {
            throw new NotImplementedException();
        }
    }
}
