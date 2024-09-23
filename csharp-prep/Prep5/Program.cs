using System;

class Program
{
    static void Main(string[] args)
    {
    //  Console.WriteLine("Hello Prep5 World!");

    DisplayWelcome();

    string userName = PromptUserName();
    int userNumber = PromptUserNumber();
    int squareNumber = SquareNumber(userNumber);

    DisplayResult(userName, squareNumber);


    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string num = Console.ReadLine();
        int number = int.Parse(num);

        return number;
    }

    static int SquareNumber(int number)
    {
        int squareNumber = number * number;

        return squareNumber;
    }

    static void DisplayResult(string name, int squareNumber)
    {
        Console.WriteLine($"{name}, the square of your favorite number is {squareNumber}");
    }
}