using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee name = new Employee(); // We instantiate the Employee object with FirstName and LastName.
            name.FirstName = "Sample";
            name.LastName = "Student";
            name.SayName(); // Here we are calling the SayName() method on the object. 
            Console.ReadLine();

            
        }
    }
}
