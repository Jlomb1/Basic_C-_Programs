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

            //Console.WriteLine(true && true && true && false);
            //Console.WriteLine(true && true && true || false);

            //Console.ReadLine();

            ///////////////////// Branching Examples

            //int roomTemp = 70;
            //Console.WriteLine("hi what is your name?");
            //string name = Console.ReadLine();
            //Console.WriteLine("hi, " + name + ", what is the temp where you are?");

            //int currentTemp = Convert.ToInt32(Console.ReadLine());

            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("it is exactly room temperature.");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("it is warmer than room temperature");
            //}
            //else if (roomTemp > currentTemp)
            //{
            //    Console.WriteLine("it is colder than room temperature");
            //}
            //else
            //{
            //    Console.WriteLine("uuuuuuuuuuuuuh, something went wrong.");
            //}


            Console.WriteLine("what is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string results = favNum >= 12 ? "you have an awesome number" : "your number sucks";

            Console.WriteLine(results);
            Console.ReadLine();




            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("it is exactly room temperature!");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("it is warmer than room temperature!");
            //}
            //else if (roomTemp > currentTemp)
            //{
            //    Console.WriteLine("room temp is warmer than current temp!");
            //}
            //else
            //{
            //    Console.WriteLine("it is NOT exactly room temperature");
            //}

            //string comparisonResult = currentTemp == roomTemp ? "it is room temp!" : "it is NOT room temp!";

            //Console.WriteLine(comparisonResult);

            
        }
    }
}
