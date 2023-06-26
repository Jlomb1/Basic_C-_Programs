using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            var mathOperation = new MathClass(); // Instantiate an instants of MathClass.

            Console.WriteLine("Please enter a number: "); // first number from user (data/result)
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine()); // second number from user (data2)

            mathOperation.MathOp(num1, num2); // Call MathOp method in the MathClass w/ user input num1 and num2.
            mathOperation.MathOp(data: num1, data2: num2); // call method again specifying the "parameter" names.
            Console.ReadLine(); 
        }
    }
}
