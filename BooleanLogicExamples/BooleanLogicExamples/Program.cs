using System;


namespace BooleanLogicExamples
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);

            //Console.WriteLine(true || true);
            //Console.WriteLine(true || false);
            //Console.WriteLine(false || false);

            //Console.WriteLine(true == true);
            //Console.WriteLine(true == false);
            //Console.WriteLine(false == false);

            //Console.WriteLine(true != true);
            //Console.WriteLine(true != false);
            //Console.WriteLine(false != false);

            //Console.WriteLine(true ^ true); //
            //Console.WriteLine(true ^ false);
            //Console.WriteLine(false ^ false);

            Console.WriteLine(true && true && true && false);
            Console.WriteLine(true && true && true || false);

            Console.ReadLine();
        }
    }
}
