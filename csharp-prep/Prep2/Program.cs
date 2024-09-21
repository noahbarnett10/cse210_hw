using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        string userPercentage = Console.ReadLine();
        int percentage = int.Parse(userPercentage);
        string letter;

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"You have a {letter} for this course.");
        
        if (percentage >= 70)
        {
            Console.WriteLine("You have passed the course.");
        }
        else
        {
            Console.WriteLine("You have not passed. Better luck next time!");
        }
    }
}