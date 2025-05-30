
public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
    public SimpleGoal(string name, string description, int points, bool completionStatus) : base(name, description, points)
    {
        _isComplete = completionStatus;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override string GetStringRepresentation()
    {
        return $"Simple goal: {GetNameOfGoal()}, {GetDescriptionOfGoal()}, {GetAmountOfPoints()}, {IsComplete()}";
    }
    
}