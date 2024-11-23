
public abstract class BaseGoal
{
    public string _goalName;
    protected string _goalDescription;
    protected bool _isComplete;
    protected int _pointValue;
    protected int _goalPointValue;
    protected DateTime? _completionDate;

    public BaseGoal(string goalName, string goalDescription, bool isComplete, int pointValue, int goalPointValue)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _isComplete = isComplete;
        _pointValue = pointValue;
        _goalPointValue = goalPointValue;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract void DisplayGoalStatus();
    public abstract int GetPoints();
    public abstract string GetStringRepresentation();

    public void GetGoal()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
    
        Console.Write("Write a short description for your goal: ");
        _goalDescription = Console.ReadLine();
        
        Console.Write("How many points for completing this goal? ");
        _goalPointValue = int.Parse(Console.ReadLine());
    }
 
}