using System;
using System.Collections.Generic;


namespace _6partArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // PART 1 ------------------------ Creating a One-Dimensional array of strings. 
            string[] stringArray1 = new string[5];
            stringArray1[0] = "Colorado ";
            stringArray1[1] = "Arizona ";
            stringArray1[2] = "Oregon ";
            stringArray1[3] = "Florida ";
            stringArray1[4] = "Texas ";

            // Creating an input for the user for some random text.
            Console.WriteLine("Please enter an adjective: ");
            string stateIn = Console.ReadLine();

            // Here we create a loop that ITERATES through each string in the array.
            for (int i = 0; i < stringArray1.Length; i++)
            {
                stringArray1[i] = stringArray1[i] + stateIn; // As the loop iterates the each string in the array it adds the user input text (stateIn).
            }

            // This created a SECOND loop that prints off each string in the array with the added user input.
            for (int i = 0; i < stringArray1.Length; i++)
            {
                Console.WriteLine(stringArray1[i]);
            }
            Console.ReadLine();


            // PART 2 ---------------------- Example of INFINITE LOOP with fixed solution.
            int infiniteLoop = 0; // Added an initialization.
            while (true) // Here is the condition.
            {
                Console.WriteLine("infiniteLoop = {0}", infiniteLoop);
                infiniteLoop++; // Here we increment from 0.
                if (infiniteLoop > 5) // If the initialization is greater than 5 it will "break" from the loop.
                    break;
            }
            Console.ReadLine();


            // PART 3 ----------------- Example of using the "<" operator in a loop.
            int lessLoop = 0;
            while (lessLoop < 101)
            {
                Console.WriteLine(lessLoop + " bottles of beer on the wall.");
                lessLoop++;
            }
            Console.ReadLine();

            // Example of using the "<=" operator in a loop.
            int lessEqual = 90;
            if (lessEqual <= 92)
            {
                Console.WriteLine("Your almost to the half way mark!");
            }
            else
            {
                Console.WriteLine("Your finally at or over level 92! Only half way to 99!");
            }
            Console.ReadLine();


            // PART 4 ---------------------- creating a list of strings.
            List<string> stringList = new List<string>();
            stringList.Add("cow");
            stringList.Add("dog");
            stringList.Add("cat");
            stringList.Add("pig");
            stringList.Add("fox");
            stringList.Add("rat");
            stringList.Add("mouse");
            stringList.Add("horse");
            stringList.Add("big foot");
            stringList.Add("the local skin walker");

            // User input text to search for an item in the list.
            Console.WriteLine("Please type your favorite animal: ");
            string animalFav = Console.ReadLine();

            bool found = false;

            // Loop that iterates through the list and then displays the index of the list item that contains matching text on the screen.
            for (int j = 0; j < stringList.Count; j++)
            {
                if (stringList[j] == animalFav)
                {
                    // Set flag to "TRUE".
                    found = true;
                    Console.WriteLine("Found it at index " + j);
                    break; //This stops the loop from executing once a match has been found.
                }
            }
            if (!found) //IF NOT FOUND i.e FALSE. 
            {
                Console.WriteLine("Uh oh! It looks like your animal is not in the this list."); // This is if there is NO matching text in the list.
            }
            Console.ReadLine();


            // Part 5 --------------------- 
            List<string> stringListTwo = new List<string>();
            stringListTwo.Add("snake");
            stringListTwo.Add("donkey");
            stringListTwo.Add("lion");
            stringListTwo.Add("tiger");
            stringListTwo.Add("bear");
            stringListTwo.Add("sheep");
            stringListTwo.Add("goat");
            stringListTwo.Add("giraffe");
            stringListTwo.Add("snake"); // Added an identical string.
            stringListTwo.Add("monkey");
            stringListTwo.Add("he who remains");

            // User input text to search for an item in the list.
            Console.WriteLine("Please type your favorite animal but this time type your favorite animal again (I know crazy right?): ");
            string animalFavorite = Console.ReadLine();

            bool foundAgain = false;

            // Loop that iterates through the list and then displays the index of the list item that contains matching text on the screen.
            for (int g = 0; g < stringListTwo.Count; g++)
            {
                if (stringListTwo[g] == animalFavorite)
                {
                    // Set flag to "TRUE".
                    foundAgain = true;
                    Console.WriteLine("Found it at index " + g);
                    // got rid of the "break;" because if we kept the break it would'nt continue the loop after finding the first "snake".
                }
            }
            if (!foundAgain) //IF NOT FOUND i.e FALSE. 
            {
                Console.WriteLine("Uh oh! It looks like your animal is not in the this list."); // This is if there is NO matching text in the list.
            }
            Console.ReadLine();


            // PART 6 ------------------------ use List.Contains(what ever the variable would be via aimalFav)
            // Use an If/Else stmnt to check if variable is in second list
            // If it is; "this item is a dup" - else "this item is unique" + add variable to the second list
            List<string> stringListThree = new List<string>(); // Created a list of string names.
            stringListThree.Add("Adam");
            stringListThree.Add("Joe");
            stringListThree.Add("Josh");
            stringListThree.Add("Steve");
            stringListThree.Add("Bob");
            stringListThree.Add("Jaclyn");
            stringListThree.Add("John");
            stringListThree.Add("Bob");
            stringListThree.Add("Jack");
            stringListThree.Add("Kyle");
            stringListThree.Add("Bob");

            List<string> stringListDupPass = new List<string>(); // Created a second list that is empty so the "unique" names are added.

            Console.WriteLine("Here is an example of iterating through the list and finding what is a dup and what is unique.");

            foreach (string uniquelo in stringListThree) // Iterates through stringListThree to find the duplicate.
            {               
                if (stringListDupPass.Contains(uniquelo)) // This says; IF you find example name "bob" again print "this name is a dup".
                {
                    Console.WriteLine(uniquelo + " - this name is a duplicate"); 
                }
                else
                {
                    Console.WriteLine(uniquelo + " - this name is unique"); // ELSE if you dont find example name "bob" again, print "this name is unique".
                    stringListDupPass.Add(uniquelo); // THEN add the unique name to stringListDupPass
                }
            }
            Console.WriteLine(stringListDupPass.Count); // Prints the amount in this list.
            Console.ReadLine();
        }
    }
}
