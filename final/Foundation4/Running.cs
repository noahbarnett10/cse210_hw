

public class Running : BaseActivity
{
    private double _distance;

    public Running(string date, int lengthTime, double distance) :base(date, lengthTime)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance/_lengthTime)*60.0;
    }
    public override double GetPace()
    {
        return _lengthTime/_distance;
    }

}