using System;

// Used resources
// https://www.bytehide.com/blog/streamwriter-csharp
// https://learn.microsoft.com/en-us/dotnet/api/system.io.file.exists?view=net-9.0

// to exceed the basic requirements I added the test of wrong input from user and I added the possibility
// to write the listing made by user to a text file. The file is created if it does not exist. If the file 
// already exists then the current listing is added to the file


class Program
{
    static void DisplayMenu()
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine(" 1. Start breathing activity");
        Console.WriteLine(" 2. Start reflecting activity");
        Console.WriteLine(" 3. Start listing activity");
        Console.WriteLine(" 4. Quit");
    }

    static void ProcessingUserChoice(string choice)
    {
        switch (int.Parse(choice))
        {
            case 1:
                Console.Clear();
                BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathingActivity.Run();
                Console.Clear();
                break;
            case 2:
                ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflectionActivity.Run();
                Console.Clear();
                break;
            case 3:
                ListingActivity listingActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listingActivity.Run();
                Console.Clear();
                break;
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        string userChoice;

        Console.Clear();

        do
        {
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
                Console.WriteLine("Please, enter an intiger in the range from 1 to 4");
                Console.WriteLine();
            }
        } while (userChoice != "4");
    }
}