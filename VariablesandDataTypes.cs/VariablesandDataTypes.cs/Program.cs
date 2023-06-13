using System;

namespace VariablesandDataTypes.cs
{
    class Program
    {
        static void Main()
        {
            // This is a program with an understanding of variables and data types
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemp = -23;
            char randomLetter = 'X';
            char questionMark = '\u2103';

            decimal moneyinBank = 100.5m; //'m' is for the compiler to understand for decimal type
            double heightinCentimeters = 2.11204985;
            float secondsLeft = 2.62f; //'f' for float type
            short temperatureonMars = -341;

            string myName = "Joe";


            // Example of 'casting' or converting
            int currentAge = 26;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(rainingStatus);
            Console.ReadLine();
            
        }
    }
}
