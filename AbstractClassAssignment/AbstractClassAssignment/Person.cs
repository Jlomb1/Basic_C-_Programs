using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public abstract class Person // Created an abstract class called Person with two properties.
    {
        // Two properties: Firstname and LastName.
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual void SayName() // Created method SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}
