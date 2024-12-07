

class Reception : BaseEvent
{
    private string _rsvpMessage;

    public Reception(string eventTitle, string eventDescription, string eventDate, string eventTime, Address eventAddress, string rsvpMessage) : base(eventTitle, eventDescription, eventDate, eventTime, eventAddress)
    {
        _rsvpMessage = rsvpMessage;
    }

    public string ReceptionMessage()
    {
        return $"{StandardMessage()}\nPlease RSVP @ {_rsvpMessage}";
    }


}