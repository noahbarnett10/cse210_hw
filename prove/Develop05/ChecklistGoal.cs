
public class ChecklistGoal : BaseGoal
{
    private int _checklistGoalNum;
    private int _checklistCompleteNum;
    private int _bonusPointValue;
    public ChecklistGoal(string goalName, string goalDescription, bool isComplete, int pointValue, int goalPointValue, int checklistGoalNum, int checklistCompleteNum, int bonusPointValue) : base(goalName, goalDescription, isComplete, pointValue, goalPointValue)
    {
        _checklistGoalNum = checklistGoalNum;
        _checklistCompleteNum = checklistCompleteNum;
        _bonusPointValue = bonusPointValue;
    }

    public void CreateGoal()
    {
        GetGoal();
        Console.Write("How many events does this checklist goal have? ");
        _checklistGoalNum = int.Parse(Console.ReadLine());
        _checklistCompleteNum = 0;
        Console.Write("How many bonus points when the goal is completed entirely? ");
        _bonusPointValue = int.Parse(Console.ReadLine());
    }
    public override void RecordEvent()
    {
        if (_checklistCompleteNum < _checklistGoalNum)
        {
            _checklistCompleteNum++;
            _completionDate = DateTime.Now;
            _pointValue += _goalPointValue;
            Console.WriteLine($"Event recorded for your goal, {_goalName}! You have complted {_checklistCompleteNum}/{_checklistGoalNum} events. You earned {_goalPointValue} points!");
        
            if (_checklistCompleteNum >= _checklistGoalNum)
            {
                _isComplete = true;
                Console.WriteLine($"Congratulations! You have completed your goal, {_goalName}! You have earned {_bonusPointValue} additional points!");
            }
        }
        else
        {
            Console.WriteLine($"Your goal, {_goalName}, has already been completed.");
        }
    }

    public override bool IsComplete()
    {
        if (_checklistCompleteNum >= _checklistGoalNum)
        {
            _isComplete = true; 
        }
        return _isComplete;    
    }

    public override void DisplayGoalStatus()
    {
        string goalStatus = _isComplete ? "[X]" : "[]";
        string completionInfo = (_isComplete && _checklistCompleteNum >= _checklistGoalNum) ? $" - Completed {_completionDate.Value.ToString("MMMM dd, yyyy hh:mm tt")}" : "";         
        Console.WriteLine($"{goalStatus} {_goalName}: {_goalDescription}, {_checklistCompleteNum}/{_checklistGoalNum} ({_goalPointValue} points, Bonus: {_bonusPointValue}){completionInfo}");
        Console.WriteLine($"    Progress: {_checklistCompleteNum}/{_checklistGoalNum} [{new string('X', _checklistCompleteNum)}{new string('-', _checklistGoalNum - _checklistCompleteNum)}]");
    }

    public override int GetPoints()
    {
        if (IsComplete())
        {
            return _pointValue + _bonusPointValue;
        }
        return _pointValue;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_goalName},{_goalDescription},{_isComplete},{_pointValue},{_goalPointValue},{_checklistGoalNum},{_checklistCompleteNum},{_bonusPointValue}";    
    }

    public static ChecklistGoal CreateChecklistGoalFromString(string goalData)
    {
        string[] parts = goalData.Split(',');
        string name = parts[0].Trim();
        string description = parts[1].Trim();
        bool isComplete = bool.Parse(parts[2].Trim());
        int points = int.Parse(parts[3].Trim());
        int goalPointValue = int.Parse(parts[4].Trim());
        int checklistGoalNum = int.Parse(parts[5].Trim());
        int checklistCompleteNum = int.Parse(parts[6].Trim());
        int bonusPointValue = int.Parse(parts[7].Trim());

        return new ChecklistGoal(name, description, isComplete, points, goalPointValue, checklistGoalNum, checklistCompleteNum, bonusPointValue); 
    }
}