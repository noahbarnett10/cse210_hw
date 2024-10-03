using System;

partial class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        int userResponse = 0;
        while (userResponse != 5)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userResponse = int.Parse(Console.ReadLine());

            if (userResponse == 1) {
                Write writePrompt = new Write();
                writePrompt.promptFun(args); // Calling the Write.cs 
                // string fileName = "myJournal.txt";
                // using (StreamWriter outputFile = new StreamWriter(fileName))
                // {
                //     outputFile.WriteLine();
                // }

            }

            else if (userResponse == 2) {
                string fileName = "myJournal.txt";
                string [] lines = System.IO.File.ReadAllLines(fileName);

                foreach(string line in lines) {
                    Console.WriteLine(line);
                }
            }

            else if (userResponse == 3) {
               

            }

            else if (userResponse == 4) {
            Save saved = new Save();
                saved.saveFun();

            }
        }

    }
}