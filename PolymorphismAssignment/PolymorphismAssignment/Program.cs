using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable quit = new Employee(); // Polymorphism to create object of type IQuittable.
            quit.Quit(); // Called the Quit() method to print the method on screen.
            Console.ReadLine();
        }
    }
}
