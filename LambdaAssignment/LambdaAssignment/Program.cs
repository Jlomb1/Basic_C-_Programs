using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Created list of 10 employees.
            List<Employee> employee = new List<Employee>()
            {
                new Employee {FirstName = "Joe", LastName = "Lombardo", ID = 1},
                new Employee {FirstName = "Jon", LastName = "Jacobs", ID = 2},
                new Employee {FirstName = "Adam", LastName = "Warlock", ID = 3},
                new Employee {FirstName = "Joe", LastName = "Dirt", ID = 4},
                new Employee {FirstName = "Hannah", LastName = "Montana", ID = 5},
                new Employee {FirstName = "Eric", LastName = "Andre", ID = 6},
                new Employee {FirstName = "Holly", LastName = "Berry", ID = 7},
                new Employee {FirstName = "Daniel", LastName = "Radcliff", ID = 8},
                new Employee {FirstName = "Joe", LastName = "Shmoe", ID = 9},
                new Employee {FirstName = "Brenor", LastName = "Smith", ID = 10}
            };
            // Created NEW list of employees where the foreach loop will put the FirstName "Joe" into.
            List<Employee> employeeNewList = new List<Employee>();

            foreach (Employee name in employee)
            {
                if (name.FirstName == "Joe")
                {
                    employeeNewList.Add(name);
                }
            }
            // Created a foreach for the employeeNewList where the FirstName and LastName can be displayed. 
            foreach (Employee name in employeeNewList)
            {
                //Console.WriteLine(name.FirstName + " " + name.LastName); 
                Console.WriteLine("{0} {1}", name.FirstName, name.LastName);
            }
            Console.WriteLine();

            // Created a Lambda expression for the employeeJoeList where the Firstname and Last name can be displayed.
            var employeeJoeList = employee.Where(x => x.FirstName == "Joe").ToList();

            // This will display the the employeeJoeList.
            foreach (Employee name in employeeJoeList)
            {
                Console.WriteLine("{0} {1}", name.FirstName, name.LastName);
            }
            Console.WriteLine();

            // Lambda expression that makes a list of all employees with an ID number greater than "5".
            var employeeIdList = employee.Where(x => x.ID > 5).ToList(); // need help

            // This displays the results of the new employeeIdList with ID's greater than 5.
            foreach (Employee name in employeeIdList)
            {
                Console.WriteLine("{0} {1} {2}", name.FirstName, name.LastName, name.ID);
            }
            Console.ReadLine();
        }
    }
}
