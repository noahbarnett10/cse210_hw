class BaseActivity
{
    protected int _activityTime;
    protected string _activityName;
    protected string _activityDescription;


    public BaseActivity(string activityName, string activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
        // _activityTime = activityTime;
    }

    public string WelcomeMessage()
    {
        return $"Welcome to the {_activityName} Activity!\n";
    }
    public void GetActivityTime()
    {
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _activityTime = int.Parse(Console.ReadLine());
    }

    public void BeginActivity()
    {
        Console.Clear();
        Console.WriteLine(WelcomeMessage());
        Console.WriteLine(_activityDescription);
        GetActivityTime();
        
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner(1);
    }

    public void EndActivity()
    {
        Console.WriteLine("\nWell done!");
        Spinner(1);
        Console.WriteLine($"You have completed another {_activityTime} seconds of the {_activityName} Activity.");
        Spinner(1);
    }

    public void Countdown(int duration)
    {
        for (int i = duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void Spinner(int duration)
    {
        List<string> spinnerStrings = new List<string>();
        spinnerStrings.Add("|");
        spinnerStrings.Add("\\");
        spinnerStrings.Add("-");
        spinnerStrings.Add("/");
        spinnerStrings.Add("|");
        spinnerStrings.Add("\\");
        spinnerStrings.Add("-");
        spinnerStrings.Add("/");

        for (int i = duration; i > 0; i--)
        {
            foreach (string s in spinnerStrings)
            {
                Console.Write(s);
                Thread.Sleep(750);
                Console.Write("\b \b");   
            }
        }

    }

    public void DotDotDot()
    {
        for (int i = 3; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
    }


}