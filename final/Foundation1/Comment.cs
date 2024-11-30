

class Comment
{
    private string _commentName;
    private string _commentText;


    public Comment(string commentName, string commentText)
    {
        _commentName = commentName;
        _commentText = commentText;

    }


    public void DisplayComment()
    {
        Console.WriteLine($"{_commentName}: {_commentText}");
    }
    


}