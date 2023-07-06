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
                new Employee {FirstName = "Joe", LastName = "Lombardo", ID = 234344},
                new Employee {FirstName = "Jon", LastName = "Jacobs", ID = 108512},
                new Employee {FirstName = "Adam", LastName = "Warlock", ID = 530931},
                new Employee {FirstName = "Joe", LastName = "Dirt", ID = 208112},
                new Employee {FirstName = "Hannah", LastName = "Montana", ID = 599817},
                new Employee {FirstName = "Eric", LastName = "Andre", ID = 539428},
                new Employee {FirstName = "Holly", LastName = "Berry", ID = 448653},
                new Employee {FirstName = "Daniel", LastName = "Radcliff", ID = 298751},
                new Employee {FirstName = "Joe", LastName = "Shmoe", ID = 234444},
                new Employee {FirstName = "Brenor", LastName = "Smith", ID = 894831}
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
            // Lambda expression that makes a list of all employees with an ID number greater than "5".
            var id = employee.Where(x => x.ID > 5).Max(); // need help.
            employeeNewList.Add(id); 
            Console.WriteLine(id);
            Console.ReadLine();
        }
    }
}
