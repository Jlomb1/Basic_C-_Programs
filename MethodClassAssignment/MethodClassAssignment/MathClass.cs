using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    public class MathClass
    {
        public void MathOp(int data = 25, int data2 = 62) // "Void" indicates to NOT returning data. If "int" were in its place
                                                          // the class would then be returning an int, but void means nothing is returned.
        {
            var result = data * 4;
            Console.WriteLine(data2);
            Console.WriteLine(result);
        }
    }
}
