
public abstract class Goal
{
    private string _nameOfGoal;
    private string _descriptionOfGoal;
    protected int _points;


    public Goal(string name, string description, int points)
    {
        _nameOfGoal = name;
        _descriptionOfGoal = description;
        _points = points;

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

    public virtual int GetAmountOfPoints()
    {
        return _points;
    }

    public void SetAmountOfPoints(int points)
    {
        _points = points;
    }


    public abstract bool IsComplete();

    public virtual void UpdateCompletenessSatus(bool complete)
    {

    }

    public virtual string GetDetailsString()
    {
        string achieved = (IsComplete()) ? "X" : " ";
        return $"[{achieved}] {GetNameOfGoal()} ({GetDescriptionOfGoal()})";
    }

    public abstract string GetStringRepresentation();

    public abstract void RecordEvent();
}