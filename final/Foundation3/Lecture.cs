

class Lecture : BaseEvent
{
    private string _speaker;
    private int _capacity;

    public Lecture(string eventTitle, string eventDescription, string eventDate, string eventTime, Address eventAddress, string speaker, int capacity) : base(eventTitle, eventDescription, eventDate, eventTime, eventAddress)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string LectureMessage()
    {
        
        return $"\n{StandardMessage()}\nPresentation by {_speaker} for a crowd of {_capacity}";
    }
}