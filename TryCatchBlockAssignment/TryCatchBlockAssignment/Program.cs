using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchBlockAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNum = new List<int> { 45, 32, 48, 23, 68, 98, 92, 73, 66 }; // Created list of numbers.

            bool correctlyEntered = false; // set to false to perform "while" loop.
            while (!correctlyEntered) // This ensures that if an error is caught (i.e "catch") the program loops around so the user can re-enter a number.
            {
                try
                {
                    Console.WriteLine("Please input a number to divide each number in the list by: ");
                    string numberInput = Console.ReadLine();
                    int numberConvert = Convert.ToInt32(numberInput);
                    int numberOutput = numberConvert;

                    for (int i = 0; i < listOfNum.Count; i++) // Iterates through the list so that the listCalc can divide each number.
                    {
                        int listCalc = listOfNum[i] / numberOutput; // user number is divided by the list of numbers. 
                        Console.WriteLine("Your number " + numberOutput + " divided by all of the numbers in the list equals " + listCalc);
                    }
                    correctlyEntered = true; // if the number is correctly entered it will break from the loop.
                }
                catch (FormatException ex) // catch error for  a string.
                {
                    Console.WriteLine(ex.Message + " Only enter a number please!");
                }
                catch (DivideByZeroException ex) // catch error if divided by zero.
                {
                    Console.WriteLine(ex.Message + " Please do not deivide by zero!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine("Done with try/catch!"); // message that displays it has emerged from the try/catch block.
            Console.ReadLine();

        }
    }
}
