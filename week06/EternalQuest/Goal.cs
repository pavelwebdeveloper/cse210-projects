
public abstract class Goal
{
    private bool _achievedStatus;
    private string _nameOfGoal;
    private string _descriptionOfGoal;
    private int _amountOfPoints;
    

    public Goal(bool status, string name, string description, int points)
    {
        _achievedStatus = status;
        _nameOfGoal = name;
        _descriptionOfGoal = description;
        _amountOfPoints = points;
        
    }

    public string GetNameOfGoal()
    {
        return _nameOfGoal;
    }

    public void SetNameOfGoal(string name)
    {
        _nameOfGoal = name;
    }
    

    public string GetDescriptionOfGoal()
    {
        return _descriptionOfGoal;
    }

    public void SetDescriptionOfGoal(string description)
    {
        _descriptionOfGoal = description;
    }

    public int GetAmountOfPoints()
    {
        return _amountOfPoints;
    }

    public void SetAmountOfPoints(int points)
    {
        _amountOfPoints = points;
    }
    

    public string GetAchievedStatus()
    {
        return (_achievedStatus == true) ? "X" : " ";
    }

    public void SetAchievedStatus(string status)
    {
        if (status == "X")
        {
            _achievedStatus = true;
        }
        else if (status == " ")
        {
            _achievedStatus = false;
        }
    }

    public virtual string GoalInformation()
    {

        return $"[{GetAchievedStatus()}] {GetNameOfGoal()} ({GetDescriptionOfGoal()})";
    }

    public abstract string PrepareGoalToSaveToTxtFile();
}