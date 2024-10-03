using System.IO;

    public class Write
{
        public void promptFun(string[] args)
    {
        string[] _prompts = new string[5];
        _prompts[0] = "Who was the most interesting person I interacted with today?";
        _prompts[1] = "What was the best part of my day?";
        _prompts[2] = "How did I see the hand of the Lord in my life today?";
        _prompts[3] = "What was the strongest emotion I felt today?";
        _prompts[4] = "If I had one thing I could do over today, what would it be?";
        Random rnd = new Random();
        Console.WriteLine(_prompts[rnd.Next(0,5)]);
        Console.ReadLine();
    }
    }




