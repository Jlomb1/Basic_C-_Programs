using System;


namespace StringFunctionsExamples
{
    class Program
    {
        static void Main()
        {
            //string name = "Joe";
            //string quote = "The man said, \"hello\", Joe. \n Hello on a new line! \n \t hello on a tab."; 
            //string filename = "C:\\user\\joe"; // The "@" sign tells the program that everything inside the quotes is apart of the string

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("e");

            //int length = name.Length;

            //name = name.ToUpper(); // or you can use ToLower();

            //Console.WriteLine(name);
            //Console.ReadLine();

            //string name = "joe";
            //name = "mama";

            //Console.WriteLine(name);
            //Console.ReadLine();

            string fName = "John";
            string mName = "Jacob";
            string lName = "jingleheimerschmidt";

            // Note on "StringBuilder", cannot locate on console as a usable element. 

            mName = mName.ToUpper();

            Console.WriteLine(fName + " " + mName + " " + lName);
            Console.ReadLine();
        }
    }
}
