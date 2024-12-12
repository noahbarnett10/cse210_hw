

class BaseEvent
{
    private string _eventTitle;
    private string _eventDescription;
    private string _eventDate;
    private string _eventTime;
    private Address _eventAddress;

    public BaseEvent(string eventTitle, string eventDescription, string eventDate, string eventTime, Address eventAddress)
    {
        _eventTitle = eventTitle;
        _eventDescription = eventDescription;
        _eventDate = eventDate;
        _eventTime = eventTime;
        _eventAddress = eventAddress;
    }

    public string StandardMessage()
    {
        return $"{_eventTitle}\n{_eventDescription}\nDate: {_eventDate} @ {_eventTime}\n{_eventAddress.GetAddress()}";
    }

    public string ShortMessage()
    {
        return $"\n{this.GetType().Name} Event\n{_eventTitle}\nDate: {_eventDate} @ {_eventTime}";

    }
}