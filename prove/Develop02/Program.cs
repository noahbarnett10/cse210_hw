using System;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.InteropServices;

class PromptGenerator 
{
    public static string PromptFun(string[] args)
    {
        string[] _prompts = new string[5];
        _prompts[0] = "Who did I have the best conversation with today?";
        _prompts[1] = "What was the most notable part of my day today?";
        _prompts[2] = "What are some blessings I noticed today?";
        _prompts[3] = "What emotions did I feel today?";
        _prompts[4] = "If I had one thing I could do over today, what would it be?";
        Random rnd = new Random();
        // Console.WriteLine(_prompts[rnd.Next(0,5)]);
        string randomPrompt = (_prompts[rnd.Next(0,5)]);

        return randomPrompt;
    }
}

class Entry 
{
    public static void JournalEntry(string randomPrompt)
    {
        string filename = "myFile.txt";
        using (StreamWriter outputFile = new StreamWriter(filename, append: true))
        {
        outputFile.WriteLine($"\nDate: {DateTime.Now.ToString("yyyy-MM-dd")}");
        Console.WriteLine($"\nDate: {DateTime.Now.ToString("yyyy-MM-dd")}");
        // PromptGenerator.PromptFun(new string[0]); 
        outputFile.WriteLine($"Prompt: {randomPrompt}");
        Console.WriteLine($"Prompt: {randomPrompt}");
        outputFile.Write("> ");
        Console.Write("> ");
        string Entry = Console.ReadLine();
        outputFile.WriteLine(Entry);
        }
    }
}

class Journal
{
    public static void DisplayJournal()
    {
        string filename = "myFile.txt";
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }

    public static string[] LoadJournal()
    {
        Console.Write("What is the file name: ");
        string filename = Console.ReadLine();
        string[] fileContents;
        if (File.Exists(filename))
        {
            fileContents = File.ReadAllLines(filename);
            string tempFileName = "myFile.txt";
            using (StreamWriter tempFile = new StreamWriter(tempFileName, append: false))
            {
            foreach (string line in fileContents)
            {
                tempFile.WriteLine(line);
            }
            }

        }
        else 
        {
            Console.WriteLine("That file does not exist.");
            fileContents = [];
        }
        return fileContents;
    }

    public static void SaveJournal()
    {
        Console.Write("What is the file to save to? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename, append: false))
        {
            string txtFile = "myFile.txt";
            string[] lines = File.ReadAllLines(txtFile);
            foreach (string line in lines)
            {
                outputFile.WriteLine(line);
            }
        }

    }
}

class Program
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

            if (userResponse == 1) 
            {
                string randomPrompt = PromptGenerator.PromptFun(args);
                Entry.JournalEntry(randomPrompt);
            }

            else if (userResponse == 2) 
            {
                Journal.DisplayJournal();
            }

            else if (userResponse == 3) 
            {
               Journal.LoadJournal();
            }

            else if (userResponse == 4) 
            {
                Journal.SaveJournal();
            }
        }
    string filename = "myFile.txt";
    using (StreamWriter outputFile = new StreamWriter(filename, append: false))
    {
        Console.WriteLine("");
    }
    }
}