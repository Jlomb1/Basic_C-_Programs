using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorSubmissionAssignment
{
    public class Employee
    {
        // Created Employee class with the properties Id, FirstName, and LastName
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }

        // Overload operator "==" that checks if two Employee objects are equal by comparing thier "Id" property. 
        public static bool operator== (Employee employee, Employee employee1) 
        {
            return employee.Id == employee1.Id; // return - is employee.Id equaled too employee1.Id?
        }
        public static bool operator!= (Employee employee, Employee employee1) // "!=" is created as overload operators must be in pairs.
        {
            return employee.Id != employee1.Id; // return - "is not".
        }
    }
}
