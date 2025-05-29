
public class SimpleGoal : Goal
{
    public SimpleGoal(bool status, string name, string description, int points) : base(status, name, description, points)
    {

    }

    public override string PrepareGoalToSaveToTxtFile()
    {
        return $"Simple goal: {GetAchievedStatus()}, {GetNameOfGoal()}, {GetDescriptionOfGoal()}, {GetAmountOfPoints()}";
    }
    
}