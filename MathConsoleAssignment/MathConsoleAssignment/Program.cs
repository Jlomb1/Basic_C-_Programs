using System;

namespace MathConsoleAssignment
{
    class Program
    {
        static void Main()
        {
            // This takes an input from the user, multiplies it by 50 and then prints the result in the console.
            Console.WriteLine("Enter a number that you would like to have multiplied by 50.");
            string multNumber = Console.ReadLine();
            int multNum = Convert.ToInt32(multNumber);
            int multTotal = multNum * 50;
            Console.WriteLine("Your entered number multiplied by 50 is: " + multTotal);
            Console.ReadLine();

            // This takes an input from the user, adds it by 25 and then prints the result in the console.
            Console.WriteLine("Enter a number that you would like to have added by 25.");
            string addNumber = Console.ReadLine();
            int addNum = Convert.ToInt32(addNumber);
            int addTotal = addNum + 25;
            Console.WriteLine("Your entered number plus 25 is: " + addTotal);
            Console.ReadLine();

            // This takes an input from the user, divides it by 12.5 and then prints the result in the console.
            Console.WriteLine("Enter a number that you would like to have divided by 12.5.");
            string divNumber = Console.ReadLine();
            double divNum = Convert.ToDouble(divNumber);
            double divTotal = divNum / 12.5;
            Console.WriteLine("Your entered number divided by 12.5 is: " + divTotal);
            Console.ReadLine();

            // This takes an input from the user and check if it is greater than 50 (i.e true or false).
            Console.WriteLine("Enter a number to see if its greater than 50.");
            string greaterThanNumber = Console.ReadLine();
            int greaterThanNum = Convert.ToInt32(greaterThanNumber);
            bool greaterThanTotal = greaterThanNum > 50;
            Console.WriteLine(greaterThanTotal);
            Console.ReadLine();

            // This takes an input from the user, divides it by 7, then prints the remainder to the console (i.e %).
            Console.WriteLine("Enter a number. This will find the remainder of that number after being divided by 7.");
            string modNumber = Console.ReadLine();
            int modNum = Convert.ToInt32(modNumber);
            int modTotal = modNum % 7;
            Console.WriteLine("The remainder is: " + modTotal);
            Console.ReadLine();

        }
    }
}
