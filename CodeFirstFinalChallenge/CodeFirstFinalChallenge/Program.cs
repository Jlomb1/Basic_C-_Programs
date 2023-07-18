using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstFinalChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                // Input from the user for First name and Last name.
                Console.Write("Please enter your first name: ");
                var fname = Console.ReadLine();

                Console.Write("Please enter your last name: ");
                var lname = Console.ReadLine();

                // Created data base that utilizes "code first method" to put values into FirstName, LastName, and StudentId.
                var student1 = new Student { FirstName = fname, LastName = lname };
                db.Students.Add(student1);         

                // This saves the changes to the data base.
                db.SaveChanges();

                // This uses the System.Data.Entity from the Entity Framework plug-in to understand SQL syntax.
                var query = from b in db.Students
                            orderby b.LastName
                            select b;
                
                // Here we can show what has been added to the database (including the automatically generated number for StudentId).
                Console.WriteLine("All student in the database: ");
                foreach (var item in query)
                {
                    Console.WriteLine(item.FirstName, item.LastName);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }

    // Database.
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
