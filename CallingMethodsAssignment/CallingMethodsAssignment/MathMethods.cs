using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    public class MathMethods // Class MathMethod "public" for other programs to utilize.
    {
        public int DoAdd(int data) // Method 1 - Add by 50.
        {
            return data + 50;
        }
        public int DoSubtract(int data) // Method 2 - Minus by 22.
        {
            return data - 22;
        }
        public int DoDivide(int data) // Method 3 - Divide by 2.
        {
            return data / 2;
        }
    }
}
