using System;

namespace ExceptionsHandlingExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simple program that divides two user input numbers, but what happens if they enter a string and not an int?
            // We use a TRY CATCH BLOCK
            // Exception handling gives you the ability to put in custom error messages, log info to a database, log errors, etc. (also debugging).
            try
            {
                Console.WriteLine("Pick a number: ");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number: ");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message); //"ex.Message" is what the user will see if an error pops up instead of an error we would see (less scary).
            }                                  // You can also type out your own message if you want.
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don\'t divide by zero!");
            }
            catch (Exception ex) // Lets say you want to catch an error but dont know what that error might be, you can use "Exception" as a general excetion.
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine(); // Log to database that a card was charge if taking card info as an example.
            }
            

        }
    }
}
