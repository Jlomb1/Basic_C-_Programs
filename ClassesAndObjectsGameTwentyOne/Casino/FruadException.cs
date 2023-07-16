using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class FruadException : Exception
    {
        // What we are doing here is creating two constructors (one of them overloading the other) and having them implement the exact same implementation that exists for exception.
        public FruadException()
            : base() { } // This is doing exactly what would happen as if we created a new exception, its just inherting.
        public FruadException(string message)
            : base(message) { }
    }
}
