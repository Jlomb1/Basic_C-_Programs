using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            var MathOperation = new MathDiv();

            // VOID method ---------------------------------------------------
            Console.WriteLine("Pleaser enter a number: ");
            int mathIn = Convert.ToInt32(Console.ReadLine());

            MathOperation.MathOp(data: mathIn); // This displays the result on screen after calling the method on that user input.

            // OUTPUT parameters --------------------------------------------
            int a = 100; // int a is equaled to 100.
            
            Console.WriteLine("before method call, value of a : {0}", a); // Prints on screen showing the value of "a".

            MathOperation.AddMath(out a); // This changes the value of "a" by the method AddMath.

            Console.WriteLine("After method call, value of a : {0}", a); // Prints on screen showing the value of "a" after passing through the method. 
            Console.ReadLine();

            // OVERLOAD methods ---------------------------------------------
            int num1 = 30;
            int num2 = 25;
            Console.WriteLine(MathOperation.MultiplyMath(num1));
            Console.WriteLine(MathOperation.MultiplyMath(num2));

            // STATIC class -------------------------------------------------
            MyStaticClass.MyStaticMethod();  // Prints on screen the console.WriteLine in method MystaticMethod.
            Console.ReadLine();
        }
    }
}
