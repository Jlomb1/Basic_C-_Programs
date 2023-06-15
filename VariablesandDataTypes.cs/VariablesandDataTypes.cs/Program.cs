using System;

namespace VariablesandDataTypes.cs
{
    class Program
    {
        static void Main()
        {
            ////////////////////////////////////////// This is a program with an understanding of variables and data types
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

            //bool isStudying = false;
            //byte hoursWorked = 42;
            //sbyte currentTemp = -23;
            //char randomLetter = 'X';
            //char questionMark = '\u2103';

            //decimal moneyinBank = 100.5m; //'m' is for the compiler to understand for decimal type
            //double heightinCentimeters = 2.11204985;
            //float secondsLeft = 2.62f; //'f' for float type
            //short temperatureonMars = -341;

            //string myName = "Joe";


            // Example of 'casting' or converting
            //int currentAge = 26;
            //string yearsOld = currentAge.ToString();

            //bool isRaining = true;
            //string rainingStatus = Convert.ToString(isRaining);
            //Console.WriteLine(rainingStatus);
            //Console.ReadLine();

            //int num1 = 5;
            //int num2 = 20;
            //int total = num1 + num2;
            //Console.WriteLine(total);
            //Console.ReadLine();

            //int num3 = 30;
            //int num4 = 40;
            //int total2 = num3 - num4;
            //Console.WriteLine(total2);
            //Console.ReadLine();

            //int num5 = 6;
            //int num6 = 10;
            //int total3 = num5 * num6;
            //Console.WriteLine(total3);
            //Console.ReadLine();

            //int num7 = 16;
            //int num8 = 2;
            //int total4 = num7 / num8;
            //Console.WriteLine(total4);
            //Console.ReadLine();

            //string fname = "john";
            //string mname = "jacobs";
            //string lname = "jinglehimerschmitt";
            //Console.WriteLine(fname + mname + lname);
            //Console.ReadLine();

            //////////////////////////////////////////////////////////// Math and comparison operators

            //int total = 5 + 10;
            //Console.WriteLine("Five plus ten = " + total.ToString());
            //Console.ReadLine();

            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();


            //double quotion = 100.0 / 17.0;
            //Console.WriteLine(quotion);
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 12 < 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();

            //int roomTemp = 70;
            //int currentTemp = 70;

            ////bool isWarm = currentTemp <= roomTemp;
            //bool isWarm = currentTemp == roomTemp; //OR '!=' which is NOT EQUAL

            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            //string name = "joe";

            //if (name == "joe")
            //{
            //    Console.WriteLine("joe who?");
            //    Console.ReadLine();
            //}
            //else if (name == "joe who?")
            //{
            //    Console.WriteLine("joe mama!");
            //}
            //else
            //{
            //    Console.WriteLine("joe who?");
            //    Console.ReadLine();
            //}

            //string name2 = "jak";

            //if (name2 == "jack")
            //{
            //    Console.WriteLine("Hello jack!");
            //}
            //else
            //{
            //    Console.WriteLine("Wait a minute....Your not jack...");
            //}
            //Console.ReadLine();

            //int age = 12;

            //if (age < 21)
            //{
            //    Console.WriteLine("You may not purchase this bottle of fine wine.");
            //}
            //else
            //{
            //    Console.WriteLine("Your total will be $20.00 have a great day!");
            //}
            //Console.ReadLine();

            int num1 = 50;
            int num2 = 55;

            string result = num1 < num2 ? "numOne is less than numTwo" : "numOne is NOT less than numTwo";
            Console.WriteLine(result);
            Console.ReadLine();


        }
    }
}
