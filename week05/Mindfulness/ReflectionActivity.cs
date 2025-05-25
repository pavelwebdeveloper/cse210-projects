

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string> {"Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."};
    private List<string> _questions = new List<string> {"Why was this experience meaningful to you?",
        "Have you ever done anything like this before?", "How did you get started?",
        "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
    public ReflectionActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        StartActivity();

        DisplayPrompt();

        DisplayQuestions();

        DisplayEndingMessage();
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        PromptGenerator promptGenerator = new PromptGenerator(_prompts);
        promptGenerator.GenerateAndShowPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string emptyInput = Console.ReadLine();
    }

    public void DisplayQuestions()
    {
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowAnimation(5, "counter");
        Console.WriteLine();
        DateTime finishTime = GetActivityFinishTimeBasedOnDuration(GetActivityDuaration());

        int i = 0;
        Console.Clear();

        while (DateTime.Now < finishTime)
        {
            string question = _questions[i++];
            Console.Write($" > {question} ");
            ShowAnimation(10, "spinner");
            Console.WriteLine();

            if (i >= _questions.Count)
            {
                i = 0;
            }
        }
    }
}