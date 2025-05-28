
public class ChecklistGoal : Goal
{
    private int _timesOfAccomplishment;

    private int _totalTimesToAccomplish;

    private int _bonusForAccomplishment;
    public ChecklistGoal(string name, string description, int points, int timesToAccomplish, int bonusForAccomplishment) : base(name, description, points)
    {
        _timesOfAccomplishment = 0;
        _totalTimesToAccomplish = timesToAccomplish;
        _bonusForAccomplishment = bonusForAccomplishment;
    }
    public override string GoalInformation()
    {
        return $"[{GetAchievedStatus()}] {GetNameOfGoal()} ({GetDescriptionOfGoal()}) -- Currently completed: {_timesOfAccomplishment}/{_totalTimesToAccomplish}";
    }
}