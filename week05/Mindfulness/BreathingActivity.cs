

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }

    public void DisplayBreathInBreathOutMessages()
    {

        for (int i = 0; i <= GetActivityDuaration(); i += 10)
        {
            Console.Write("Breathe in...");
            ShowAnimation(3, "counter");
            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowAnimation(5, "counter");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}