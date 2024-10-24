using System;
using System.Runtime.InteropServices;



class Program
{
    static void Main(string[] args)
    {
        string text = "But the fruit of the Spirit is love, joy, peace, longsuffering, gentleness, goodness, faith, meekness, temperance: against such there is no law.";
        ScriptureText scriptureText = new ScriptureText("Galatians", "5", "22-23", text);


        
        Console.WriteLine("Welcome to the scripture memorizer. Hit 'Enter' to remove words. Type 'quit' to exit.");
        scriptureText.DisplayReference();
        scriptureText.DisplayScripture();

        while (true)
        {
        string UserEntry = Console.ReadLine();
        if (UserEntry == "")
        {
            Console.Clear();
            if (!scriptureText.HideWords(4))
            {
                Console.WriteLine("All words hidden. Exiting now.");
                break;
            }
            scriptureText.DisplayReference();
            scriptureText.DisplayScripture();
        }
        else if (UserEntry == "quit")
        {
            Console.WriteLine("Exiting now.");
            break;
        }
        }
    }
}