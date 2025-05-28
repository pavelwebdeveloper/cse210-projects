
public class ChecklistGoal : Goal
{
    private int _timesOfAccomplishment;

    private int _totalTimesToAccomplish;

    private int _bonusForAccomplishment;
    public ChecklistGoal(bool status, string name, string description, int points, int timesOfAccomplishment, int timesToAccomplish, int bonusForAccomplishment) : base(status, name, description, points)
    {
        _timesOfAccomplishment = timesOfAccomplishment;
        _totalTimesToAccomplish = timesToAccomplish;
        _bonusForAccomplishment = bonusForAccomplishment;
    }
    public override string GoalInformation()
    {
        return $"[{GetAchievedStatus()}] {GetNameOfGoal()} ({GetDescriptionOfGoal()}) -- Currently completed: {_timesOfAccomplishment}/{_totalTimesToAccomplish}";
    }

    public int GetTimesOfAccomplishment()
    {
        return _timesOfAccomplishment;
    }

    public void SetTimesOfAccomplishment(int timesOfAccomplishment)
    {
        _timesOfAccomplishment = timesOfAccomplishment;
    }

    public int GetTotalTimesToAccomplish()
    {
        return _totalTimesToAccomplish;
    }

    public void SetTotalTimesToAccomplish(int timesToAccomplish)
    {
        _totalTimesToAccomplish = timesToAccomplish;
    }

    public int GetBonusForAccomplishment()
    {
        return _bonusForAccomplishment;
    }

    public void SetBonusForAccomplishment(int bonusForAccomplishment)
    {
        _bonusForAccomplishment = bonusForAccomplishment;
    }

    public override string PrepareGoalToSaveToTxtFile()
    {
        return $"Checklist goal: {GetAchievedStatus()} {GetNameOfGoal()} {GetDescriptionOfGoal()} {GetAmountOfPoints()} {GetTimesOfAccomplishment()} {GetTotalTimesToAccomplish()} {GetBonusForAccomplishment()}";
    }

}