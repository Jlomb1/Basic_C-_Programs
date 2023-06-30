using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try // Will run user input day of the week if entered correctly.
            {
                Console.WriteLine("Please enter the current day of the week: "); // User input for the current day of the week. 
                string currentDay = Console.ReadLine();

                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), currentDay); // Assigned value to a varaible of the enum data type DaysOfTheWeek.

                Console.WriteLine("It is currently " + day + "!");
            }
            catch // If user input is not any of the days it will print this to console.
            {
                Console.WriteLine("Please enter a valid day of the week: ");
            }
            Console.ReadLine();


        }
        public enum DaysOfTheWeek // Created enum DaysOfTheWeek.
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
