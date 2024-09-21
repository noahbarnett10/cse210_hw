using System;

class Program
{
    static void Main(string[] args)
    {
       // Console.WriteLine("Hello Prep3 World!");

        // Console.Write("What is the magic number? ");
        // string userNumber = Console.ReadLine();
        // int magicNumber = int.Parse(userNumber);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100);

        int userGuess = 0;
        string playAgain = "yes";
        while (playAgain == "yes")
        {
        do
        {
            Console.Write("What is your guess? ");
            string userGuessString = Console.ReadLine();
            userGuess = int.Parse(userGuessString);
        
            if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else 
            {
                Console.WriteLine("Nice job! You guessed it!");
            }
        

        } while (userGuess != magicNumber);

        Console.Write("Do you want to play again? ");
        playAgain = Console.ReadLine();
        }

       
      
    }
}