using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1st user input for Method 1 (int).
            Console.WriteLine("Please enter a number: ");
            int numberConvert = Convert.ToInt32(Console.ReadLine());
            int numberOut = numberConvert;

            var mathOperators = new Math1(); // Created variable to call class MathOps.
            int resultMath = mathOperators.Math(numberOut);

            // End result for Method 1.
            Console.WriteLine(numberOut + " + 25 = " + resultMath);


            // 2nd user input for Method 2 (decimal).
            Console.WriteLine("Please enter a decimal: ");
            decimal decimalCon = Convert.ToDecimal(Console.ReadLine()); // Convert ToDecimal for user input.
            decimal decimalOut = decimalCon;

            // End result for Method 2.
            Console.WriteLine(mathOperators.Math(decimalOut));


            // 3rd user input for Method 3 (string).
            Console.WriteLine("Please enter a number but in string form: "); 
            string stringIn = Console.ReadLine(); // Convert to int32 in Math class.

            Console.WriteLine(mathOperators.Math(stringIn));

            // End result for Method 3.
            Console.ReadLine();

        }
    }
}
