using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsGameTwentyOne
{
    public abstract class Game 
    {
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();

        public List<Player> Players { get { return _players; } set { _players = value; } }
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } } // Dictionary of players and bets.

        public abstract void Play(); 

        public virtual void ListPlayers() 
        {
            foreach (Player player in Players) 
            {
                Console.WriteLine(player.Name);
            }
        }     
    }   
}

// "abstract" keyword - This class can NEVER be instantiated (it can never be an object, only meant to be inherited from.
// "abstract method" - is a method; can only exist inside an "abstract class", and contains NO implimentation.
// The abstract method essentially states; any class inheriting this class MUST implement this method. 
// "virtual" method inside of an abstract class means that this method gets inherited by an inheriting class
// but it has the ability to "override" it.
// Remember "void" doesn't return anything its just printing to the console.