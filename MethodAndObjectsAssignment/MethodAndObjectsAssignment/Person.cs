using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAndObjectsAssignment
{
    public class Person // Created a class name "Person".
    {
        // Gave class "Person" two properties of data type string (FirstName, LastName).
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Void method called SayName() that takes NO parameters (i.e variables inside the method).
        public void SayName()
        {
            // This simply writes the persons full name to the console.
            Console.WriteLine("Name: " + FirstName + " " + LastName);
            Console.ReadLine();
        }
    }
}
