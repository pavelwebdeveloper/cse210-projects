using System;
using System.IO;


public class ListingActivity : Activity
{
    public ListingActivity(string name, string description, List<string> prompts) : base(name, description, prompts)
    {

    }

    public void ShowPromptForListingAndProcessListing()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        string prompt = GenerateAndShowPrompt();
        Console.Write("You may begin in: ");
        ShowAnimation(5, "counter");
        Console.WriteLine();

        DateTime finishTime = GetActivityFinishTimeBasedOnDuration(GetActivityDuaration());
        using StreamWriter outputFile = new StreamWriter("listing_results.txt");

        string time = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
        outputFile.WriteLine();
        outputFile.WriteLine(time);
        outputFile.WriteLine(prompt);

        int numberOfListedItems = 0;

        while (DateTime.Now < finishTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            outputFile.WriteLine(item);
            numberOfListedItems++;
        }

        if (numberOfListedItems == 1)
        {
            Console.WriteLine($"You listed {numberOfListedItems} item!");
        }
        else
        {
            Console.WriteLine($"You listed {numberOfListedItems} items!");
        }
        Console.WriteLine();
    }

}