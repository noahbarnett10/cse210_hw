
using System.Linq.Expressions;
using System.Threading;

class ListingAct : BaseActivity
{
    private string _randomPrompt;
    private static Random _rnd = new Random();

    public ListingAct() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        List<string> prompts = new List<string>
        {
            "Who are some people that have inspired you and guided you the most?", 
            "What are some blessings you noticed today?", 
            "What are some of your spiritual gifts?", 
            "How have you felt God's love for you this month?", 
            "How have you been served or served others this week?"
        };

        _randomPrompt = prompts[_rnd.Next(prompts.Count)];
    }

    public void ListAct()
    {
        BeginActivity();

        DateTime endTime = DateTime.Now.AddSeconds(_activityTime);

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine(_randomPrompt);

        int count = 0;
        while (DateTime.Now < endTime)
        {
            
            Console.Write("> ");
            string userInput = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(userInput))
            {
                count++;
            }
        }
        Console.WriteLine($"You listed {count} items!");
        EndActivity();

    }

    
}