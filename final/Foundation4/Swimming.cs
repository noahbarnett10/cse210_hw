

public class Swimming : BaseActivity
{
    private int _laps;

    public Swimming(string date, int lengthTime, int laps) :base(date, lengthTime)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return _laps* 50 / 1000 * 0.62;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / _lengthTime) * 60.0;
    }
    public override double GetPace()
    {
        return _lengthTime / GetDistance();
    }
}