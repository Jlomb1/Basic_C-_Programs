using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: "); // user input integer.
            string numberInput = Console.ReadLine();
            int numberConvert = Convert.ToInt32(numberInput);
            int numberOutput = numberConvert;

            var operatorObject = new MathMethods(); // Constructor to assign values to an object from MathMethods file.
            var resultAdd = operatorObject.DoAdd(numberOutput); // Call DoAdd method with user input
            var resultSub = operatorObject.DoSubtract(numberOutput); // Call DoSubtract method with user input 
            var resultDiv = operatorObject.DoDivide(numberOutput); // Call DoDivide method with user input - ALL to assign variable to return integer.

            // This displays the returned integer after being passed through all 3 methods.
            Console.WriteLine(numberOutput + " + 50 = " + resultAdd + 
                "\n" + numberOutput + " - 22 = " + resultSub + 
                "\n" + numberOutput + " / 2 = " + resultDiv);
            Console.ReadLine();
        }
        public int Data { get; set; } // Need more clarification on this ****
    }
}
