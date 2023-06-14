using System;

namespace IncomeComparisonProgram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            // PERSON 1
            Console.WriteLine("Person 1:");
            Console.WriteLine("Please enter the hourly rate");
            string hourlyRate = Console.ReadLine();
            double hourlyInput = Convert.ToDouble(hourlyRate);
            double hourlyTotal = hourlyInput;

            Console.WriteLine("Please enter the hours worked per week");
            string hourWorked = Console.ReadLine();
            double workRate = Convert.ToDouble(hourWorked);
            double workTotal = workRate;
            Console.WriteLine("Your hourly rate is " + hourlyTotal + " and your hours worked per week is " + workTotal);

            // PERSON 2
            Console.WriteLine("Person 2:");
            Console.WriteLine("Please enter the hourly rate");
            string hourlyRate2 = Console.ReadLine();
            double hourlyInput2 = Convert.ToDouble(hourlyRate2);
            double hourlyTotal2 = hourlyInput2;

            Console.WriteLine("Please enter the hours worked per week");
            string hourWorked2 = Console.ReadLine();
            double workRate2 = Convert.ToDouble(hourWorked2);
            double workTotal2 = workRate2;
            Console.WriteLine("Your hourly rate is " + hourlyTotal2 + " and your hours worked per week is " + workTotal2);


            // Hourly rate multiplied by hours worked for Person 1
            double annualSalary = hourlyTotal * workTotal;
            double salaryTotal = annualSalary * 52;
            Console.WriteLine("Annual salary of Person 1: " + salaryTotal);


            // Hourly rate multiplied by hours worked for Person 2
            double annualSalary2 = hourlyTotal2 * workTotal2;
            double salaryTotal2 = annualSalary2 * 52;
            Console.WriteLine("Annual salary of Person 2: " + salaryTotal2);

            // Boolean determines if Person 1 makes more than Person 2 (i.e true or false)
            bool CompTorF = salaryTotal > salaryTotal2;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(CompTorF);
            Console.ReadLine();
        }
    }
}
