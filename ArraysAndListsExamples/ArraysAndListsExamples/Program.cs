using System;
using System.Collections.Generic; // Using it when we get into LISTS

namespace ArraysAndListsExamples
{
    class Program
    {
        static void Main()
        {
            List<int> intList = new List<int>(); // Creating a list, LISTS are the most common in C#.
            intList.Add(4);
            intList.Add(10);
            intList.Remove(10);

            Console.WriteLine(intList[0]);
            Console.ReadLine();

            List<string> stringList = new List<string>(); // Example of using string to create a list.
            stringList.Add("cat");
            stringList.Add("dog");
            stringList.Add("mouse");

            Console.WriteLine(stringList[2]);
            Console.ReadLine();

            // There are also byte arrays.

            //int[] numArray = new int[5]; // This says int array called numArray equals new int array of length 5.
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;

            //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 }; // This is the same thing as above but ALOT easier to write.
            //                                                     // Notice that there is no set number in the int[] as well.

            //int[] numArray2 = { 5, 2, 10, 200, 5000 }; // This is the same thing as above but EVEN MORE easier to write.

            //numArray2[2] = 15; // This changes the element in the index.

            //Console.WriteLine(numArray2[2]);
            //Console.ReadLine();

        }
    }
}
