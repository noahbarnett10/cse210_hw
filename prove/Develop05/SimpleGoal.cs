
public class SimpleGoal : BaseGoal
{

    public SimpleGoal(string goalName, string goalDescription, bool isComplete, int pointValue, int goalPointValue) : base(goalName, goalDescription, isComplete, pointValue, goalPointValue)
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
            _isComplete = true;
            _completionDate = DateTime.Now;
            _pointValue += _goalPointValue;
            Console.WriteLine($"Your goal, {_goalName}, is complete! You earned {_goalPointValue} points!");
        }
        else
        {
            Console.WriteLine($"Your goal, {_goalName}, has already been completed.");
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override void DisplayGoalStatus()
    {
        string goalStatus = _isComplete ? "[X]" : "[]";
        string completionInfo = _completionDate.HasValue ? $" - Completed {_completionDate.Value.ToString("MMMM dd, yyyy hh:mm tt")}" : ""; 
        Console.WriteLine($"{goalStatus} {_goalName}: {_goalDescription} ({_goalPointValue} points){completionInfo}");
    }

    public override int GetPoints()
    {
        return _pointValue;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_goalName},{_goalDescription},{_isComplete},{_pointValue},{_goalPointValue}";
    }

    public static SimpleGoal CreateSimpleGoalFromString(string goalData)
    {
        string[] parts = goalData.Split(',');
        string name = parts[0].Trim();
        string description = parts[1].Trim();
        bool isComplete = bool.Parse(parts[2].Trim());
        int points = int.Parse(parts[3].Trim());
        int goalPoints = int.Parse(parts[4].Trim());

        return new SimpleGoal(name, description, isComplete, points, goalPoints); 
    }
}