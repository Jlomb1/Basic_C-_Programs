using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTimeSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Printed the current date and time to the console i.e DateTime.Now.
            Console.WriteLine("The time is currently " + DateTime.Now + "\nPlease enter a number: ");
            // Asked user to input a number.
            int num1 = Convert.ToInt32(Console.ReadLine());

            // Prints to the console the exact time it will in "X hours", X = num1.
            Console.WriteLine("It will be " + DateTime.Now.AddHours(num1) + " in " + num1 + " hours ");
            Console.ReadLine();
        }
    }
}
