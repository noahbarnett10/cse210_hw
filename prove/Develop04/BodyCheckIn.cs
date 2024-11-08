

class BodyCheckIn : BaseActivity
{
    private List<string> bodyParts;

    public BodyCheckIn() : base("Body Check In", "This untimed activity will help you to become more aware of each part of your body. To feel where the stress is and work to alleviate it.")
    {
        bodyParts = new List<string>
        {
            "Toes", "Feet", "Ankles", "Calves", "Butt", "Hands", "Wrists", "Shoulders", "Neck" 
        };
    }

    public void BodyScanAct()
    {
        Console.Clear();                           // Not going to BeginActivity method as this activity will be untimed
        Console.WriteLine(WelcomeMessage());
        Console.WriteLine(_activityDescription);
        Spinner(1);
        Console.Clear();

        Console.WriteLine("We will examine all parts of our body beginning at the toes, and ending with the neck. For each part, roll it and twist it and let your body notice how it feels with the movement.");
        Spinner(1);
        Console.Write("We will begin in ");
        Countdown(5);

        foreach (string part in bodyParts)
        {
            Console.WriteLine($"\nFocus on your {part}");
            Thread.Sleep(3000);
            Console.WriteLine("Notice what it feels like to move it. Make a mental note.");
            Spinner(2);
        }
        
        Console.Clear();
        Console.WriteLine("You should take some extra time on those places where you felt extra tension to work out those knots to truly unwind.");
        Console.WriteLine("Nice job!");
        Spinner(1);

    }
}