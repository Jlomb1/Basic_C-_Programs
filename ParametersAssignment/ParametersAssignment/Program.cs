using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.Things = "Eggs";
            employee.Things = "Milk";
            employee.Things = "Soap";
            employee.Things = "Butter";
            employee.Things = "Toothpaste";

            Employee<int> phoneNumber = new Employee<int>();
            phoneNumber.Things = 10231;
            phoneNumber.Things = 10928;
            phoneNumber.Things = 09093;
            phoneNumber.Things = 30921;
            phoneNumber.Things = 02982;
            
            // Need help understanding. 
        }
    }
}
