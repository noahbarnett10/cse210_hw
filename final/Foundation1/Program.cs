using System;

class Program
{
    static void Main(string[] args)
    {
        Video V1 = new Video("Basics of Woodworking", "John Johnson", 450);
        V1.AddComment("Mark", "Great lesson! Very helpful for a beginner like me!");
        V1.AddComment("Susan", "Thanks for your help with my project!");
        V1.AddComment("Troy", "Your knowledge is inspirational!");
        V1.AddComment("Karen", "I've seen better. 1 star.");

        Video V2 = new Video("Calculus for Beginners", "David Davidson", 630);
        V2.AddComment("Tony", "This was very helpful for me to help my son with his homework!");
        V2.AddComment("Denisse", "This helped me understand derivatives!");
        V2.AddComment("Bert", "Thanks.");
        V2.AddComment("Karen", "You explain things so poorly. 1 star.");
                
        Video V3 = new Video("How to change your oil", "Jacob Jacobson", 280);
        V3.AddComment("Greg", "Thanks for the help! I was tired of paying money for this simple job.");
        V3.AddComment("Tina", "Now I understand what to do so I can do it myself!");
        V3.AddComment("Jacob", "Thanks for saving me money.");
        V3.AddComment("Karen", "Your voice is annoying. 1 star.");

        Video V4 = new Video("How to play a lullaby on a Uekelele", "Jenn Jenson", 240);
        V4.AddComment("Evan", "Such a sweet melody.");
        V4.AddComment("Sarah", "This is prfect for my newborn! Thanks!");
        V4.AddComment("Destiny", "This was one of my favorites growing up!");
        V4.AddComment("Karen", "You can hardly play the uke, learn better before you post. 1 star.");

        List<Video> videos = new List<Video> {V1, V2, V3, V4};
        
        foreach (var video in videos)
        {
            video.DisplayVideo();
            video.DisplayComments();
    
        }
    }
}