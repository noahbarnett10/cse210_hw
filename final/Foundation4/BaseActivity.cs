
public abstract class BaseActivity
{
    protected string _date;
    protected int _lengthTime;

    public BaseActivity(string date, int lengthTime)
    {
        _date = date;
        _lengthTime = lengthTime;
    }
    public virtual double GetDistance() => 0;
    public virtual double GetSpeed() => 0;
    public virtual double GetPace() => 0;
    public string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_lengthTime} min) - Distance: {GetDistance():F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min/mile";
    }


}