using System;


namespace BranchingPackageExpressAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the insutrctions below.");

            // Input for weight of package
            Console.WriteLine("Please enter the weight of your package:");
            string packageWeight = Console.ReadLine();
            int weightInput = Convert.ToInt32(packageWeight);

            if (weightInput > 50) // IF the weight of the package is greater than 50 than it will exit program.
            {
                Console.WriteLine("Package too HEAVY to be shipped via Package Express. Have a good day.");
                // how do i end program here?
            }
            else
            {
                // Input for width of package
                Console.WriteLine("Please enter the width of your package:");
                string packageWidth = Console.ReadLine();
                int widthInput = Convert.ToInt32(packageWidth);

                // Input for height of package
                Console.WriteLine("Please enter the height of your package:");
                string packageHeight = Console.ReadLine();
                int heightInput = Convert.ToInt32(packageHeight);

                // Input for length of package
                Console.WriteLine("Please enter the length of your package:");
                string packageLength = Console.ReadLine();
                int lengthInput = Convert.ToInt32(packageLength);

                if (widthInput + heightInput + lengthInput > 50) // IF the width, height, and length of the package is over 50 it will exit program.
                {
                    Console.WriteLine("Package too BIG to be shipped via Package Express. Have a good day.");
                }
                else // ELSE the program will calculate the estimated cost for complete total and give output in dollar amount.
                {
                    int dimensionTotal = heightInput * widthInput * lengthInput; // This takes the height, width, and length of user input, mulitplies the three.
                    int estTotal = dimensionTotal * weightInput; // This takes the output from the top and multiplies it by the weight.
                    int completeTotal = estTotal / 100; // This takes the total from the top and divides it by 100 to give the user an estimate cost.

                    Console.WriteLine("Your estimated total for shipping this package is: $" + completeTotal + ".");
                    Console.WriteLine("Thank you!");
                }

            }
            Console.ReadLine();
        }   
    }
}
