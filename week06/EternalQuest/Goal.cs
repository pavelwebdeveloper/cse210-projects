
public abstract class Goal
{
    private string _nameOfGoal;
    private string _descriptionOfGoal;
    private int _amountOfPoints;

    private bool _achievedStatus;

    public Goal(string name, string description, int points)
    {
        _nameOfGoal = name;
        _descriptionOfGoal = description;
        _amountOfPoints = points;
    }

    public string GetNameOfGoal()
    {
        return _nameOfGoal;
    }

    public string GetDescriptionOfGoal()
    {
        return _descriptionOfGoal;
    }

    public int GetAmountOfPoints()
    {
        return _amountOfPoints;
    }

    public bool GetAchievedStatus()
    {
        return _achievedStatus;
    }

    public abstract void DisplayGoal();
}