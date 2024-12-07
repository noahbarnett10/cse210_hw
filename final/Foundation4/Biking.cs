

public class Biking : BaseActivity
{
    private double _speed;

    public Biking(string date, int lengthTime, double speed) :base(date, lengthTime)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return _speed * (_lengthTime / 60.0);
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
}