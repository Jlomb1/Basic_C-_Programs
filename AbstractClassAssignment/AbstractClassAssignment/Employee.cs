using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Employee : Person // Created class Employee that inherits (i.e ":") from the Person class. 
    {
        public override void SayName() // We "override" the method to implement the abstract method in Person called SayName().
        {
            base.SayName(); // This is essentially an equal to the SayName() method in the abstract class Person.  
        }
    }
}
