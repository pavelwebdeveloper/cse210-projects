using System;
using System.IO;


public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string> {"Who are people that you appreciate?", "What are personal strengths of yours?",
        "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"};
    private int _count = 0;

    public ListingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        StartActivity();

        Console.WriteLine("List as many responses you can to the following prompt:");
        PromptGenerator promptGenerator = new PromptGenerator(_prompts);
        string prompt = promptGenerator.GenerateAndShowPrompt();
        Console.Write("You may begin in: ");
        ShowAnimation(5, "counter");
        Console.WriteLine();

        SaveListFromUser(prompt);

        if (_count == 1)
        {
            Console.WriteLine($"You listed {_count} item!");
        }
        else
        {
            Console.WriteLine($"You listed {_count} items!");
        }

        DisplayEndingMessage();
    }

    private void SaveListFromUser(string prompt)
    {
        DateTime finishTime = GetActivityFinishTimeBasedOnDuration(GetActivityDuaration());
        using StreamWriter outputFile = new StreamWriter("listing_results.txt");

        string time = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
        outputFile.WriteLine();
        outputFile.WriteLine(time);
        outputFile.WriteLine(prompt);

        while (DateTime.Now < finishTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            outputFile.WriteLine(item);
            _count++;
        }
    }

}