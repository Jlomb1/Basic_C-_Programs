using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiated two objects of the Employee class with assigned values employee & employee1.
            Employee employee = new Employee();
            Employee employee1 = new Employee();
            
            employee.Id = 10931;
            employee.Firstname = "Joe";
            employee.LastName = "Lombardo";

            employee1.Id = 10932;
            employee1.Firstname = "Josh";
            employee1.LastName = "Jingle";

            // Compares the two objects using the overloaded operators and displays results to console. 
            if (employee == employee1)
            {
                Console.WriteLine("They are equal");
            }
            else
            {
                Console.WriteLine("They are NOT equal");
            }
            Console.ReadLine();
    

        }
    }
}
