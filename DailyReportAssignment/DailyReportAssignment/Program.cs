using System;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy.");
            Console.WriteLine("Student Daily Report.");

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine(); //string for a name

            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine(); //string for the course name 

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);
            int total = pageNum;
            Console.WriteLine("You entered: " + total); //converting the string to an int to input into the console.readline()

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            string needHelp = Console.ReadLine();
            bool helpStat = Convert.ToBoolean(needHelp);
            bool status = helpStat;
            Console.WriteLine("you answered: " + status); //converting the string to a boolean to input into the console.readline()

            Console.WriteLine("Were there any positive experiences you\'d like to share? Please give specifics.");
            string feedBack = Console.ReadLine(); //string for feed back

            Console.WriteLine("Is there any other feedback you\'d like to provide? Please be specific.");
            string feedBack2 = Console.ReadLine(); //string for feed back 2
            Console.WriteLine("Thank you for your feed back!");

            Console.WriteLine("How many hours did you study today?"); 
            string studyHours = Console.ReadLine();
            float hours = Convert.ToInt32(studyHours);
            float studyTotal = hours;
            Console.WriteLine("You entered: " + studyTotal); //converting the string to a float to input into the console.readline()

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine(); //end!
        }
    }
}
