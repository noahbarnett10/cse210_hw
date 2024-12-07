using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("1234 Pioneer Road", "Rexburg", "ID", "USA");

        Lecture lecture = new Lecture("Networking Symposium", "Learn the basics of networking using LinkedIn", "December 12, 2024", "4:00pm", address, "Lincoln Link", 350);
        Reception reception = new Reception("Graduation", "Graduation celebration for Steven", "December 19, 2024", "6:00pm", address, "stevenstevesteve@gmail.com");
        Outdoor outdoor = new Outdoor("Community Potluck", "Spend time in the community with friends, bring your favorite dish", "May 13, 2025", "2:00pm", address, "Partly cloudy with a high of 74");

        Console.WriteLine(lecture.StandardMessage());
        Console.WriteLine(lecture.LectureMessage());
        Console.WriteLine(lecture.ShortMessage());

        Console.WriteLine(reception.StandardMessage());
        Console.WriteLine(reception.ReceptionMessage());
        Console.WriteLine(reception.ShortMessage());

        Console.WriteLine(outdoor.StandardMessage());
        Console.WriteLine(outdoor.OutdoorMessage());
        Console.WriteLine(outdoor.ShortMessage());

    }
}