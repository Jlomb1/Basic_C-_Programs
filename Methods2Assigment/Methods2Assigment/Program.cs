using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2Assigment
{
    class Program
    {
        static void Main(string[] args)
        {
            var mathObject = new MathPar(); // Assigning variable to MathPar i.e MathObject.

            Console.WriteLine("Please enter two numbers one at a time: "); // First number input for user.
            int numberConvert = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Second number (you do not need enter anything for the second number): "); // Second number input for user.
            try // The "try" will try the code below i.e first user input (data) and second user input (data2) then return the result.
            {
                int twoConvert = Convert.ToInt32(Console.ReadLine());
                int result = mathObject.Math(numberConvert, twoConvert); // REMEMBER the comma is different from the "+". 
                Console.WriteLine(result);
            } 
            catch // If the user does not enter a second number it will catch this error and data2 will default to 50 in MathPar class.
            {
                int result = mathObject.Math(numberConvert);
                Console.WriteLine(result);
            }
            Console.ReadLine();
            
        }
    }
}
