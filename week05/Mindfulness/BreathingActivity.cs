

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        StartActivity();

        for (int i = 0; i < GetActivityDuaration(); i += 10)
        {
            Console.Write("Breathe in...");
            ShowAnimation(4, "counter");
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowAnimation(6, "counter");
            Console.WriteLine();
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}