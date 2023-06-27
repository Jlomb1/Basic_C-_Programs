using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAndObjectsAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Person person = new Person(); NOTE: We DO NOT need this - here for reference.

            // Instantiated Employee.
            Employee employee = new Employee();

            // Initialized Employee object with first name "sample" and last name "student".
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            // Here we are calling the SUPERCLASS method SayName() on the Employee Object. 
            employee.SayName();

            Console.ReadLine();
        }
    }
}
