using System.Threading;

class BreathingAct : BaseActivity
{
    public BreathingAct() : base("Breathing", "This activity will help you relax by walking you through a slow breathing treatment. Clear your mind and focus on your breathing.")
    {
    }

    public void Breathe()
    {
        BeginActivity();

        DateTime endTime = DateTime.Now.AddSeconds(_activityTime);

        while (DateTime.Now < endTime)
        {
        Console.Write("\nBreathe in... ");
        Countdown(4);
        Console.Write("\nNow breathe out... ");
        Countdown(6);
        }

        EndActivity();
    }

}