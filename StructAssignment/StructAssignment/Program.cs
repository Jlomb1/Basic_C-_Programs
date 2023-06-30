using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number(); // Created an object of data type Number.
            number.Amount = 4; // Assigned an amount to "number".
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
