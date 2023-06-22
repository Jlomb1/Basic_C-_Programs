using System;
using System.Collections.Generic;


namespace IterationExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            //// This whole FOR loop "iterates" over the array and gives us our passing test scores.
            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]); 
            //    }
            //}
            //Console.ReadLine();


            //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    //if (names[j] == "Adam")
            //    //{
            //    //    Console.WriteLine(names[j]);
            //    //}
            //    Console.WriteLine(names[j]); // This prints all the names in the array
            //}
            //Console.ReadLine();


            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(72);
            //testScores.Add(70);

            //// Example of a FOR EACH LOOP 
            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + score);
            //    }
            //}
            //Console.ReadLine();


            //List<string> names = new List<string>() { "Jesse", "Adam", "Erik", "Daniel" };

            //foreach (string name in names)
            //{
            //    //if (name == "Adam")
            //    //{
            //    //    Console.WriteLine(name);
            //    //}
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();


            List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
            List<int> passingScores = new List<int>();

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }
            Console.WriteLine(passingScores.Count);
            Console.ReadLine();

        }
    }
}
