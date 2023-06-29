using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Employee : IQuittable // Employee class that inherits the interface IQuittable.
    {
        public void Quit() // Impliments the Quit() method.
        {
            Console.WriteLine("Here is an example of inheritance and polymorphism!"); // Prints to console.
        }
    }
}
