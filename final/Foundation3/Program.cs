using System;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("1234 Pioneer Road", "Rexburg", "ID", "USA");

        var Events = new List<BaseEvent>
        {
        new Lecture("Networking Symposium", "Learn the basics of networking using LinkedIn", "December 12, 2024", "4:00pm", address, "Lincoln Link", 350),
        new Reception("Graduation", "Graduation celebration for Steven", "December 19, 2024", "6:00pm", address, "stevenstevesteve@gmail.com"),
        new Outdoor("Community Potluck", "Spend time in the community with friends, bring your favorite dish", "May 13, 2025", "2:00pm", address, "Partly cloudy with a high of 74")
        };

        foreach (var e in Events)
        {
            Console.WriteLine(e.StandardMessage());
            if (e is Lecture lectureEvent)
            {
                Console.WriteLine(lectureEvent.LectureMessage());
            }
            else if (e is Reception receptionEvent)
            {
                Console.WriteLine(receptionEvent.ReceptionMessage());
            }
            else if (e is Outdoor outdoorEvent)
            {
                Console.WriteLine(outdoorEvent.OutdoorMessage());
            }
            Console.WriteLine(e.ShortMessage());
            Console.WriteLine("---------------");
        }
        
    }
}