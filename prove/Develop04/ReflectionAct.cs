
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

class ReflectionAct : BaseActivity
{
    private string _randomPrompt;
    private static Random _rndPrompt = new Random();
    private static Random _rndQuestion = new Random();


    public ReflectionAct() : base("Reflection", "This activity will help you reflect on times in your life whe you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        

        List<string> prompts = new List<string>
        {
            "Think of a time when you accomplished something you're proud of.",
            "Think of a time when you first met someone special to you.",
            "Think of a time when you served someone.",
            "Think of a time when you put someone else first.",
            "Think of a time when you were strong."
        };
            _randomPrompt = prompts[_rndPrompt.Next(prompts.Count)];

    }

        private string GetRandomQuestion()
        {
            List<string> questions = new List<string>
            {
                "How did this experience change you?", 
                "Why was this experience meaningful for you?", 
                "How did you feel afterwards?", 
                "If you could do it again, would you do anything different?", 
                "How can you keep this experience in your mind going forward?", 
                "How was this experience a teaching moment for you?", 
                "What did you feel before you did what you did?", 
                "How can you build off of this experience?", 
                "What did this experience teach you about yourself?" 
            };
            return questions[_rndQuestion.Next(questions.Count)];
        }
    

    public void ReflectAct()
    {
        BeginActivity();

        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine($"\n--- {_randomPrompt} ---\n");
        Console.WriteLine("When you are ready, press enter to continue.");
        string userReady = Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to the prompt.");
        Console.Write("Beginning in ");
        Countdown(5);

        DateTime endTime = DateTime.Now.AddSeconds(_activityTime);
        Console.Clear();
        while (DateTime.Now < endTime)
        {
        string randomQuestion = GetRandomQuestion();
        Console.WriteLine($"> {randomQuestion}");
        Spinner(2);
        }

        EndActivity();
    }
}
