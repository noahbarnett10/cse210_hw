
public class EternalGoal : BaseGoal
{

    public EternalGoal(string goalName, string goalDescription, bool isComplete, int pointValue, int goalPointValue) : base(goalName, goalDescription, isComplete, pointValue, goalPointValue)
    {
    }

    public void CreateGoal()
    {
        GetGoal();
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _pointValue += _goalPointValue;
            Console.WriteLine($"Event recorded for your goal, {_goalName}! You earned {_goalPointValue} points!");
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override void DisplayGoalStatus()
    {
        string goalStatus = _isComplete ? "[X]" : "[]";
        Console.WriteLine($"{goalStatus} {_goalName}: {_goalDescription} ({_goalPointValue} points)");
    }

    public override int GetPoints()
    {
        return _pointValue;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_goalName},{_goalDescription},{_isComplete},{_pointValue},{_goalPointValue}";
    }

     public static EternalGoal CreateEternalGoalFromString(string goalData)
    {
        string[] parts = goalData.Split(',');
        string name = parts[0].Trim();
        string description = parts[1].Trim();
        bool isComplete = bool.Parse(parts[2].Trim());
        int points = int.Parse(parts[3].Trim());
        int goalPoints = int.Parse(parts[4].Trim());

        return new EternalGoal(name, description, isComplete, points, goalPoints); 
    }
}