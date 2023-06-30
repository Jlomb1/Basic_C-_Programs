using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsGameTwentyOne
{
    public abstract class Game // "abstract" keyword - This class can NEVER be instantiated (it can never be an object, only meant to be inherited from.
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play(); // "abstract method" - is a method; can only exist inside an "abstract class", and contains NO implimentation.
                                     // The abstract method essentially states; any class inheriting this class MUST implement this method. 

        public virtual void ListPlayers() // "virtual" method inside of an abstract class means that this method gets inherited by an inheriting class
                                          // but it has the ability to "override" it.
        {
            foreach (Player player in Players) // Remember "void" doesn't return anything its just printing to the console.
            {
                Console.WriteLine(player.Name);
            }
        }
            

    }   
}
