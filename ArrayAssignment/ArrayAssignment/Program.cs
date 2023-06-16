using System;
using System.Collections.Generic;


namespace ArrayAssignment
{
    class Program
    {
        static void Main()
        {

            List<string> arrayList = new List<string>(); // String list 
            arrayList.Add("cat");
            arrayList.Add("dog");
            arrayList.Add("mouse");
            arrayList.Add("fox");
            arrayList.Add("horse");
            arrayList.Add("cow");
            arrayList.Add("pig");
            arrayList.Add("bob");

            List<int> intList = new List<int>(); // Integer list 
            intList.Add(0);
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);
            intList.Add(5);


            Console.WriteLine("Please select an animal from the array (0-7):"); // User input for string array selection.
            string arrayCon = Console.ReadLine();
            int arrayInt = Convert.ToInt32(arrayCon);
            int arrayInput = arrayInt;

            if (arrayInput > 7) // If user input is out side array then error message displays.
            {
                Console.WriteLine("Uh oh! The number you have entered does not exist!");
                Console.ReadLine();
            }
            else // Displays the element in the array to the user.
            {
                Console.WriteLine("You chose " + arrayList[arrayInput] + " from the array.");

                Console.WriteLine("How many of these would you like? Please choose up to 6:"); // User input for integer array.
                string intCon = Console.ReadLine();
                int howManyInt = Convert.ToInt32(intCon);
                int howManyInput = howManyInt;

                if (howManyInput > 6) // If user input is out side array then error displays. 
                {
                    Console.WriteLine("Uh oh! That\'s too many pets!");
                    Console.ReadLine();
                }
                else // Displays the int element in the array.
                {
                    Console.WriteLine("You will receive " + howManyInput + " of the animal you have chosen!");
                }
            }

            string[] numArray = new string[] { "Colorado", "Nevada", "Texas", "Oregon", "Florida" }; // One dimensional array example.

            Console.WriteLine("Please select from the array to display a state (0 - 4):"); // User input for the string array.
            string oneDarray = Console.ReadLine();
            int arrayExp = Convert.ToInt32(oneDarray);
            int arrayOut = arrayExp;
            Console.WriteLine("Looks like your moving to " + numArray[arrayOut] + "!");
            Console.ReadLine();

        }
    }
}
