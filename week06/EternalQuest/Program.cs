using System;
using System.Text.Json;

class Program
{
    static void DisplayPoints(int points)
    {
        Console.WriteLine();
        Console.WriteLine($"You have {points} points");
        Console.WriteLine();
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

    public static void CreateGoal(string typeOfGoal, List<Goal> goals)
    {
        Console.Write("What is the name of your goal? ");
        string nameOfGoal = Console.ReadLine();

        Console.Write("What is the short description of it? ");
        string descriptionOfGoal = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int amountOfPoints = int.Parse(Console.ReadLine());

        int timesToAccomplish = 0;
        int bonusForAccomplishment = 0;

        if (typeOfGoal == "3")
        {
            Console.Write("Howe many time does this goal need to be accomplished for a bonus? ");
            timesToAccomplish = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            bonusForAccomplishment = int.Parse(Console.ReadLine());
        }

        if (typeOfGoal == "1")
            {
                Goal goal = new SimpleGoal(nameOfGoal, descriptionOfGoal, amountOfPoints);

                goals.Add(goal);
            }
            else if (typeOfGoal == "2")
            {
                EternalGoal eternalGoal = new EternalGoal(nameOfGoal, descriptionOfGoal, amountOfPoints);

                goals.Add(eternalGoal);
            }
            else if (typeOfGoal == "3")
            {
                ChecklistGoal checklistGoal = new ChecklistGoal(nameOfGoal, descriptionOfGoal, amountOfPoints, timesToAccomplish, bonusForAccomplishment);

                goals.Add(checklistGoal);
            }
    }

    public static bool CheckChoice(string userChoice, string menuType)
    {
        if (menuType == "mainMenu")
        {
            if (userChoice != "1" && userChoice != "2" && userChoice != "3" && userChoice != "4" && userChoice != "5" && userChoice != "6")
            {
                Console.Clear();
                Console.WriteLine();

                Console.WriteLine("Please, enter an intiger in the range from 1 to 6");


                //Console.WriteLine();

                return true;
            }
            return false; 
        }
        else if (menuType == "goalCreationMenu")
        {
            if (userChoice != "1" && userChoice != "2" && userChoice != "3")
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Please, enter an intiger in the range from 1 to 3");
                return true;
            }
            return false; 
        }

        return false;
    }

    static void DisplayNewGoalCreationMenuAndGetUserChoice(List<Goal> goals)
    {
        string typeOfGoal;

        do
        {
            Console.WriteLine("The types of Goals are: ");
            Console.WriteLine(" 1. Simple Goal");
            Console.WriteLine(" 2. Eternal Goals");
            Console.WriteLine(" 3. Checklist Goals");
            Console.Write("Which type of goal would you like to create? ");
            typeOfGoal = Console.ReadLine();
        } while (CheckChoice(typeOfGoal, "goalCreationMenu"));
        
        switch (int.Parse(typeOfGoal))
        {
            case 1:
                CreateGoal(typeOfGoal, goals);
                Console.Clear();
                break;
            case 2:
                CreateGoal(typeOfGoal, goals);
                Console.Clear();
                break;
            case 3:
                CreateGoal(typeOfGoal, goals);
                Console.Clear();
                break;
        }


    }

    static void DisplayGoalsList(List<Goal> _goals)
    {
        
        

        if (_goals.Count == 0)
        {
            Console.Write($"You have no goals yet.");
        }
        else
        {
            Console.WriteLine("The goals are:");

            for (int i = 0; i < _goals.Count; i++)
            {
                Console.Write($"{i + 1} ");
                Console.WriteLine($"{_goals[i].GoalInformation()}");
                Console.WriteLine();
                
            }
        }

        DisplayPoints(0);
    }

    static void SaveToFile(string fileName, List<Goal> _goals)
    {
        /*using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                outputFile.WriteLine(_goals[i].GoalInformation());
                outputFile.WriteLine();
            }
        }*/
        /*using StreamWriter outputFile = new StreamWriter(fileName);
        outputFile.WriteLine(JsonSerializer.Serialize(_goals));*/
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                string jsonString = JsonSerializer.Serialize(_goals[i]);
                Console.WriteLine(jsonString);
                Thread.Sleep(10000);
                outputFile.WriteLine(jsonString);
            }
        }
        
    }

    static void ProcessingUserChoice(string choice, List<Goal> goals)
    {
        switch (int.Parse(choice))
        {
            case 1:
                DisplayNewGoalCreationMenuAndGetUserChoice(goals);
                break;
            case 2:
                DisplayGoalsList(goals);
                break;
            case 3:
                Console.Write("What is the file name for the goal file? ");
                string fileName = Console.ReadLine();
                SaveToFile(fileName, goals);
                Console.Clear();
                break;
            case 4:
                Console.Clear();

                Console.Clear();
                break;
            case 5:

                Console.Clear();
                break;
            case 6:

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
                ProcessingUserChoice(userChoice, _goals);
            }
            else if (CheckChoice(userChoice, "mainMenu"))
            {
            }
        } while (userChoice != "6");
    }
}