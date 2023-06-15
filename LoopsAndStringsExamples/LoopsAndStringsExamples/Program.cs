using System;


namespace LoopsAndStringsExamples
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Guess the lucky number?");
            int guessNum = Convert.ToInt32(Console.ReadLine());
            bool guessChance = guessNum == 4; // This states that true/false statemnt is that guessNum is equaled to the number 4.

            do // "DO" is performing the switch statement WHILE the guessChance is equaled to false.
            {
                switch (guessNum)
                {
                    case 400:
                        Console.WriteLine("You guessed 400, try agagin.");
                        Console.WriteLine("Guess the lucky number?");
                        guessNum = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 20:
                        Console.WriteLine("You guessed 20, try again.");
                        Console.WriteLine("Guess the lucky number?");
                        guessNum = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 69:
                        Console.WriteLine("You guessed 69, try again.");
                        Console.WriteLine("Guess the lucky number?");
                        guessNum = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("You guessed the lucky number 4, that is correct!"); // This is the true statement. 
                        guessChance = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number?");
                        guessNum = Convert.ToInt32(Console.ReadLine());
                        break;
                }

            }
            while (guessChance == false);
            Console.ReadLine();


            int num2 = 0;
            while (num2 < 101)
            {
                Console.WriteLine(num2);
                num2++;
            }
            Console.ReadLine();
        }
    }
}
