using System.Transactions;

class Video
{
    private string _videoTitle;
    private string _videoAuthor;
    private double _videoLength;
    private List<Comment> comments;


    public Video(string videoTitle, string videoAuthor, double videoLength)
    {
        _videoTitle = videoTitle;
        _videoAuthor = videoAuthor;
        _videoLength = videoLength;
        comments = new List<Comment>();
    }
    public void AddComment(string commentName, string commentText)
    {
        Comment newComment = new Comment(commentName, commentText);
        comments.Add(newComment);
    }

    public void DisplayVideo()
    {
        Console.WriteLine("------------------------------------------");
        Console.WriteLine($"Title: {_videoTitle}");
        Console.WriteLine($"Author: {_videoAuthor}");
        Console.WriteLine($"Length: {_videoLength} seconds");
        Console.WriteLine($"Number of Comments: {comments.Count}\n");
    }

    public void DisplayComments()
    {
        foreach(var comment in comments)
        {
            comment.DisplayComment();
        }
    }
}