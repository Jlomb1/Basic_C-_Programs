using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    public class MathDiv
    {
        public void MathOp(int data) // Creating a VOID method that outputs an integer. 
        {
            var result = data / 2;
            Console.WriteLine(result);
        }

        public void AddMath(out int data2) // the "out" parameter essentially takes the value assigned to "a" and changes it to "data2" value.
        {
            data2 = 25;
        }
        // Creating an overload method for MultiplyMath ---------------
        public int MultiplyMath(int i) 
        {
            return i * 5;
        }
        public int MultiplyMath(decimal g)
        {
            int result = Convert.ToInt32(g);
            return result * 10;
        }
    }
    public static class MyStaticClass // Declaring a class to be "static"
    {
        public static void MyStaticMethod()
        {
            Console.WriteLine("Here, printed here is from my static class");
        }
    }
}
