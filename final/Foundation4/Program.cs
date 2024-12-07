using System;

class Program
{
    static void Main(string[] args)
    {
        List<BaseActivity> activities = new List<BaseActivity>();

        activities.Add(new Running("01 Dec 2024", 30, 3.0));
        activities.Add(new Biking("08 Dec 2024", 45, 10));
        activities.Add(new Swimming("15 Dec 2024", 60, 20));

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}