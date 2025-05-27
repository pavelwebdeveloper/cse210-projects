using System;

class Program
{
    static void DisplayPoints(int points)
    {
        Console.WriteLine("You have {points} points");
    }
    static void DisplayMenu()
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine(" 1. Create New Goal");
        Console.WriteLine(" 2. List Goals");
        Console.WriteLine(" 3. Save Goals");
        Console.WriteLine(" 4. Load Goals");
        Console.WriteLine(" 5. Record Event");
        Console.WriteLine(" 6. Quit");
    }

    public static void CreateGoal(string typeOfGoal)
    {
        Console.Write("What is the name of your goal? ");
        string nameOfGoal = Console.ReadLine();

        Console.Write("What is the short description of it? ");
        string descriptionOfGoal = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int amountOfPointsOfGoal = int.Parse(Console.ReadLine());

        Console.Write("Howe many time does this goal need to be accomplished for a bonus? ");
        int timesOfAccomplishmentOfGoal = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing it that many times? ");
        int bonusForAccomplishments = int.Parse(Console.ReadLine());

        if (typeOfGoal == "1")
        {
            Goal goal = new SimpleGoal(nameOfGoal, descriptionOfGoal, amountOfPointsOfGoal);
        }
        else if (typeOfGoal == "2")
        {
            EternalGoal eternalGoal = new EternalGoal(nameOfGoal, descriptionOfGoal, amountOfPointsOfGoal);
        }
        else if (typeOfGoal == "3")
        {
            ChecklistGoal checklistGoal = new ChecklistGoal(nameOfGoal, descriptionOfGoal, amountOfPointsOfGoal, timesOfAccomplishmentOfGoal, bonusForAccomplishments);
        }
    }

    

    static void CreateNewGoal()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goals");
        Console.WriteLine(" 3. Checklist Goals");
        Console.Write("Which type of goal would you like to create? ");
        string typeOfGoal = Console.ReadLine();



        switch (typeOfGoal)
        {
            case 1:
                CreateGoal(typeOfGoal);
                Console.Clear();
                break;
            case 2:
                CreateGoal(typeOfGoal);
                Console.Clear();
                break;
            case 3:
                CreateGoal(typeOfGoal);
                Console.Clear();
                break;
        }

        
    }

    static void DisplayGoalsList(List<Goal> _goals)
    {
        Console.WriteLine("The goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"{i + 1} ");
            _goals[i].DisplayGoal();
            Console.WriteLine();
        }
    }

    static void ProcessingUserChoice(string choice)
    {
        switch (int.Parse(choice))
        {
            case 1:
                Console.Clear();

                Console.Clear();
                break;
            case 2:

                Console.Clear();
                break;
            case 3:

                Console.Clear();
                break;
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        List<Goal> _goals = new List<Goal>();

        string userChoice;

        Console.Clear();

        do
        {
            DisplayMenu();
            Console.Write("Select a choice from the menu: ");
            userChoice = Console.ReadLine();
            if (userChoice == "1" || userChoice == "2" || userChoice == "3" || userChoice == "4" || userChoice == "5")
            {
                Console.Clear();
                ProcessingUserChoice(userChoice);
            }
            else if (userChoice != "1" && userChoice != "2" && userChoice != "3" && userChoice != "4" && userChoice == "5" || userChoice == "6")
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Please, enter an intiger in the range from 1 to 4");
                Console.WriteLine();
            }
        } while (userChoice != "6");
    }
}