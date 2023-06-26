using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2Assigment
{
    public class MathPar
    {
        public int Math(int data, int data2 = 50) // We are giving variable data2 default data of 50 if the user does not input a second number.
        {
            return data + data2; // This returns the result of the first number input and second number input.
        }
    }
}
