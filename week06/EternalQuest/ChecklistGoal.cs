
public class ChecklistGoal : Goal
{
    private int _timesOfAccomplishmentOfGoal;

    private int _bonusForAccomplishments;
    public ChecklistGoal(string name, string description, int points, int timesOfAccomplishment, int bonusForAccomplishments) : base(name, description, points)
    {
        _timesOfAccomplishmentOfGoal = timesOfAccomplishment;
        _bonusForAccomplishments = bonusForAccomplishments;
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"[{GetAchievedStatus}] {GetNameOfGoal} ({GetDescriptionOfGoal})");
    }
}