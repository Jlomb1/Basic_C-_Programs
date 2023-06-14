using System;


namespace CarInsuranceApprovalProgram
{
    class Program
    {
        static void Main()
        {
            // Intro to Console
            Console.WriteLine("Welcome to Safe Driver\'s Using Insurance (Safe D.U.I)");
            Console.WriteLine("Please fill out the following applicant questions to determine whether you qualify or not.");

            // Input for age 
            Console.WriteLine("What is your age?");
            string ageApp = Console.ReadLine();
            int ageInput = Convert.ToInt32(ageApp);
            int ageComp = ageInput;
            Console.WriteLine("Your age is " + ageComp + ".");

            // Input for "yes" or "no" for DUI
            Console.WriteLine("Have you ever had a DUI? Please type \"yes\" or \"no\"");
            string duiApp = Console.ReadLine();
            Console.WriteLine("you said " + duiApp + ".");

            // Input for amount of speeding tickets
            Console.WriteLine("How many speeding tickets do you have?");
            string ticketApp = Console.ReadLine();
            int ticketInput = Convert.ToInt32(ticketApp);
            int ticketComp = ticketInput;
            Console.WriteLine("You have " + ticketComp + " ticket(s).");

            // Boolean logic determination for qualification or not
            Console.WriteLine("Thank you for your submission.");
            Console.WriteLine("Are you qualified? Please Press ENTER to find out.");
            Console.ReadLine();
            bool isQualified = (ageComp > 24 && duiApp == "no" && ticketComp < 5);
            Console.WriteLine(isQualified);
            Console.ReadLine();

            

        }
    }
}
