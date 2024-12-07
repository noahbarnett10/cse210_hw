

class Outdoor : BaseEvent
{
    private string _weatherForecast;

    public Outdoor(string eventTitle, string eventDescription, string eventDate, string eventTime, Address eventAddress, string weatherForecast) : base(eventTitle, eventDescription, eventDate, eventTime, eventAddress)
    {
        _weatherForecast = weatherForecast;
    }

    public string OutdoorMessage()
    {
        return $"{StandardMessage()}\n{_weatherForecast}";
    }
}