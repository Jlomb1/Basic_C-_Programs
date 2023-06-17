using System;
using System.Collections.Generic;


namespace ArrayAssignment
{
    class Program
    {
        static void Main()
        {

            string[] arrayList = new string[5]; // One-dimensional array of string 
            arrayList[0] = "cat";
            arrayList[1] = "dog";
            arrayList[2] = "mouse";
            arrayList[3] = "fox";
            arrayList[4] = "bob";

            int[] intList = new int[5]; //One_Dimensional array of intengers 
            intList[0] = 5;
            intList[1] = 10;
            intList[2] = 15;
            intList[3] = 20;
            intList[4] = 25;

            Console.WriteLine("Please select an animal from the array 0-4:"); // User input for STRING array selection.
            string arrayCon = Console.ReadLine();
            int arrayInt = Convert.ToInt32(arrayCon);
            int arrayInput = arrayInt;

            if (arrayInput > 4) // If user input is out side array then error message displays.
            {
                Console.WriteLine("Uh oh! The number you have entered does not exist!");
                Console.ReadLine();
            }
            else // Displays the element in the array to the user.
            {
                Console.WriteLine("You chose " + arrayList[arrayInput] + " from the array.");

                Console.WriteLine("How many of these would you like? Please choose from 0-4 in the array:"); // User input for INTEGER array.
                string intCon = Console.ReadLine();
                int howManyInt = Convert.ToInt32(intCon);
                int howManyInput = howManyInt;

                if (howManyInput > 4) // If user input is out side array then error displays. 
                {
                    Console.WriteLine("Uh oh! That\'s too many pets!");
                    Console.ReadLine();
                }
                else // Displays the int element in the array.
                {
                    Console.WriteLine("You will receive " + intList[howManyInput] + " of the animal you have chosen!");
                }
            }

            List<string> stringList = new List<string>(); // list of strings.
            stringList.Add("Colorado");
            stringList.Add("Orgeon");
            stringList.Add("Texas");
            stringList.Add("Florida");
            stringList.Add("Alabama");

            Console.WriteLine("Please select from the array to display a state (0 - 4):"); // User input for the string array.
            string listStr = Console.ReadLine();
            int arrayExp = Convert.ToInt32(listStr);
            int arrayOut = arrayExp;
            Console.WriteLine("Looks like your moving to " + stringList[arrayOut] + "!");

            Console.ReadLine();

        }
    }
}
