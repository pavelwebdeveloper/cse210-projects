
public class EternalGoal : Goal
{
    public EternalGoal(bool status, string name, string description, int points) : base(status, name, description, points)
    {

    }

    public override void SetAchievedStatus(bool status)
    { 
        
    }
    
    public override string PrepareGoalToSaveToTxtFile()
    {
        return $"Eternal goal: {GetAchievedStatus()}, {GetNameOfGoal()}, {GetDescriptionOfGoal()}, {GetAmountOfPoints()}";
    }
}