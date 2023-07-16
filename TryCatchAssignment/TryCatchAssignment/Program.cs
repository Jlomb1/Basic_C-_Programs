using System;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool correctlyEntered = false;
            while (!correctlyEntered)
            {
                try
                {
                    // User input for age.
                    Console.WriteLine("Please enter your age: ");
                    int ageInput = Convert.ToInt32(Console.ReadLine());

                    // How to get the year the user was born based off user input.
                    var today = DateTime.Today;
                    var age = today.Year - ageInput;

                    // If user enters anything less than 1 it will throw the catch method.
                    if (ageInput < 1)
                    {
                        throw new ArgumentException();
                    }

                    // Else if the user input is entered correctly, it will display the answer.
                    Console.WriteLine(age);
                    correctlyEntered = true;
                }
                catch (ArgumentException)
                {
                    // If the user enters anything less than 1 it will print this to the console.
                    Console.WriteLine("Please do not enter zero or negative numbers.");
                }
                catch (FormatException)
                {
                    // If the user enters letters it will print this to the console.
                    Console.WriteLine("Please enter digits only.");
                }
            }
            Console.ReadLine();
        }
    }
}
