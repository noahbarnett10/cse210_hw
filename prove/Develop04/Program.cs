using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;

        Console.WriteLine("Welcome to the Mindfulness Activity!");
        Console.WriteLine("Please select an option from the menu.");

        while (userChoice != 5)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Body Scan Activity (Untimed)");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {

                BreathingAct BA = new BreathingAct();
                BA.Breathe();
            }
            else if (userChoice == 2)
            {
                ReflectionAct RA = new ReflectionAct();
                RA.ReflectAct();
            }
            else if (userChoice == 3)
            {
                ListingAct LA = new ListingAct();
                LA.ListAct();
            }
            else if (userChoice == 4)
            {
                BodyCheckIn BCI = new BodyCheckIn();
                BCI.BodyScanAct();
            }
          
        }


    }
}