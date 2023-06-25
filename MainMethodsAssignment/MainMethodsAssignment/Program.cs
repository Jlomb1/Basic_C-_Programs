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
            Console.WriteLine("Please enter a number: "); // 1st user input for Method 1 (int).
            string numberIn = Console.ReadLine();
            int numberConvert = Convert.ToInt32(numberIn);
            int numberOut = numberConvert;

            var mathOperators = new MathOps(); // Created variable to call class MathOps.
            int resultMath = mathOperators.Math(numberOut); // 1st 'Math' method for user input integer.

            // End result for Method 1.
            Console.WriteLine(numberOut + " + 25 = " + resultMath);


            Console.WriteLine("Please enter a decimal: "); // 2nd user input for Method 2 (decimal).
            string decimalIn = Console.ReadLine();
            double decimalCon = Convert.ToDouble(decimalIn);
            double decimalOut = decimalCon;

            double resultDecimal = mathOperators.Math(decimalOut); // 2nd 'Math' utilizing 'Method Overload' for decimal.

            // End result for Method 2.
            Console.WriteLine(decimalOut + " * 2 = " + resultDecimal);


            Console.WriteLine("Please enter a number but in string form: "); // 3rd user input for Method 3 (string).
            string stringIn = Console.ReadLine();
            try // TryCatch Block to attempt converting string to integer.
            {
                int result = int.Parse(stringIn); // Converting string to integer using "int.Parse".
                Console.WriteLine(result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Unable to parse \'{stringIn}\'"); // If this doesnt work - will print the following.
            }

            string resultString = mathOperators.Math(stringIn); // 3rd 'Math' utilizing 'Method Overload' for string.

            // End result for Method 3.
            Console.WriteLine(stringIn + " + 40 = " + resultString);
            Console.ReadLine();

        }
        
        public class MathOps // Method 1 - addition.
        {
            public int Math(int data)
            {
                return data + 25;
            }
            public double Math(double data)
            {
               return data * 2;
            }
            public string Math(string data)
            {
                return data + 40;
            }
        }
    }
}
