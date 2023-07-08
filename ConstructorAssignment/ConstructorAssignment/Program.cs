using System;

namespace ConstructorAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Example of a const variable. 
            const string expConst = "Joe Shmoe";

            // Example of using a variable using the keyword "var".
            var expVar = "Joe Lombardo";

            
        }
        // Example of chaining two constructors together.
        public Program(string Firstname) : this(Firstname, "Last Name Here")
        {
            // This can be left blank as this is enough to handle the below constructor.
        }
        public Program(string Firstname, string Lastname)
        {
            Firstname = "Joe";
            Lastname = "Lombardo";
        }
    }
}
