

public class Activity
{
    private string _name;
    private string _description;
    private int _durationOfActivityInSeconds;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        SetActivityDuaration();
    }

    private void SetActivityDuaration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _durationOfActivityInSeconds = int.Parse(Console.ReadLine());
        Console.WriteLine();
    }

    public int GetActivityDuaration()
    {
        return _durationOfActivityInSeconds;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowAnimation(8, "spinner");
        Console.WriteLine();
        Console.WriteLine();
    }

    public void FinishActivity()
    {
        Console.WriteLine("Well done!!");
        ShowAnimation(8, "spinner");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_durationOfActivityInSeconds} seconds of the {_name} Activity.");
        ShowAnimation(8, "spinner");
    }

    protected void ShowAnimation(int lengthOfAnimationInSeconds, string kindOfAnimation)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(lengthOfAnimationInSeconds);

        if (kindOfAnimation == "spinner")
        {
            List<string> spins = new List<string> { "|", "/", "-", "\\", "|", "/", "-", "\\" };

            int i = 0;

            while (DateTime.Now < futureTime)
            {
                string spin = spins[i++];
                Console.Write(spin);
                Thread.Sleep(1000);
                Console.Write("\b \b");

                if (i > spins.Count)
                {
                    i = 0;
                }
            }
        }
        else if (kindOfAnimation == "counter")
        {
            for (int i = lengthOfAnimationInSeconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }
}