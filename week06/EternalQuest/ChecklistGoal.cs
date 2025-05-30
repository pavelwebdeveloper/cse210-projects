
public class ChecklistGoal : Goal
{
    private int _timesOfAccomplishment;

    private int _totalTimesToAccomplish;

    private int _bonusForAccomplishment;
    public ChecklistGoal(string name, string description, int points, int timesOfAccomplishment, int timesToAccomplish, int bonusForAccomplishment) : base(name, description, points)
    {
        _timesOfAccomplishment = timesOfAccomplishment;
        _totalTimesToAccomplish = timesToAccomplish;
        _bonusForAccomplishment = bonusForAccomplishment;
    }

    public override bool IsComplete()
    {
        if (_timesOfAccomplishment == _totalTimesToAccomplish)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        string achieved = (IsComplete()) ? "X" : " ";
        return $"[{achieved}] {GetNameOfGoal()} ({GetDescriptionOfGoal()}) -- Currently completed: {_timesOfAccomplishment}/{_totalTimesToAccomplish}";
    }

    public int GetTimesOfAccomplishment()
    {
        return _timesOfAccomplishment;
    }

    public override void RecordEvent()
    {
        _timesOfAccomplishment += 1;
    }

    public override int GetAmountOfPoints()
    {
        if (IsComplete())
        {
            return _points + _bonusForAccomplishment;
        }
        else
        {
            return _points;
        }
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

    public override string GetStringRepresentation()
    {
        return $"Checklist goal: {GetNameOfGoal()}, {GetDescriptionOfGoal()}, {GetAmountOfPoints()}, {GetTimesOfAccomplishment()}, {GetTotalTimesToAccomplish()}, {GetBonusForAccomplishment()}";
    }

}