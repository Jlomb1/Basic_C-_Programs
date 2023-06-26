using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodsAssignment
{
    public class Math1
    {
            public int Math(int data)
            {
                Console.WriteLine("int method"); // User input + 25.
                return data + 25;
            }
            public int Math(decimal data)
            {
                Console.WriteLine("decimal method"); // User input * 2 as a decimal.
                int result = Convert.ToInt32(data);
                return result * 2;
            }
            public int Math(string data)
            {
                Console.WriteLine("string method"); // User input + 40 as a string convert.
                int result = Convert.ToInt32(data);
                return result + 40;
            }
    }
}
