using System;

class Program
{
    static void DisplayMenu()
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine(" 1. Start breathing activity");
        Console.WriteLine(" 2. Start reflecting activity");
        Console.WriteLine(" 3. Start listing activity");
        Console.WriteLine(" 4. Quit");
        Console.WriteLine();

    }

    static void ProcessingUserChoice(string choice)
    {
        switch (int.Parse(choice))
        {
            case 1:
                Console.Clear();
                StartBreathingActivity();
                break;
            case 2:
                StartReflectingActivity();
                break;
            case 3:
                StartListingActivity();
                break;
        }
    }

    static void StartBreathingActivity()
    {
        BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        breathingActivity.DisplayStartingMessage();
        breathingActivity.StartActivity();
        breathingActivity.DisplayBreathInBreathOutMessages();
        breathingActivity.FinishActivity();

    }

    static void StartReflectingActivity()
    {
        
    }

    static void StartListingActivity()
    {
        
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        string userChoice;

        do
        {
            Console.Clear();
            DisplayMenu();
            Console.Write("Select a choice from the menu: ");
            userChoice = Console.ReadLine();
            if (userChoice == "1" || userChoice == "2" || userChoice == "3")
            {
                Console.Clear();
                ProcessingUserChoice(userChoice);
            }
            else if (userChoice != "1" && userChoice != "2" && userChoice != "3" && userChoice != "4")
            {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Please, enter an intiger between 1 and 5");
                    Console.WriteLine();
            }
        } while (userChoice != "4");
    }
}