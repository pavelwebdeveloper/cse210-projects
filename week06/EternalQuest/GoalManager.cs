
public class GoalManager
{
    private static List<Goal> _goals = new List<Goal>();
    private static int _score = 0;

    //private static string _nameOfFile;

    public void Start(GoalManager goalManager)
    {
        string userChoice;

        Console.Clear();

        do
        {
            DisplayMenu();
            Console.Write("Select a choice from the menu: ");
            userChoice = Console.ReadLine();
            Console.Clear();
            if (userChoice == "1" || userChoice == "2" || userChoice == "3" || userChoice == "4" || userChoice == "5")
            {
                ProcessingUserChoice(userChoice);
            }
            else if (CheckChoice(userChoice, "mainMenu"))
            {
            }
        } while (userChoice != "6");
    }

    public void SetOrUpdateScore(int points)
    {
        _score += points;
    }

    static int GetScore()
    {
        return _score;
    }

    static void DisplayScore(int points, bool afterGoalAccomplishment = false)
    {
        Console.WriteLine();
        if (afterGoalAccomplishment)
        {
            Console.WriteLine($"You now have {points} points");
        }
        else
        {
            Console.WriteLine($"You have {points} points");
        }
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

    public static void CreateGoal(string typeOfGoal, string goalString = "")
    {
        string[] goalStringArray = goalString.Split(", ");

        bool completionStatus = false;
        string nameOfGoal;
        string descriptionOfGoal;
        int points;
        int timesOfAccomplishment = 0;
        int timesToAccomplish = 0;
        int bonusForAccomplishment = 0;


        if (goalString.Length > 0)
        {
            nameOfGoal = goalStringArray[0];
            descriptionOfGoal = goalStringArray[1];
            points = int.Parse(goalStringArray[2]);

            if (typeOfGoal == "Simple goal")
            {
                
                if (goalStringArray[3] == "True")
                {
                    completionStatus = true;
                }
                else
                {
                    completionStatus = false;
                }
            }

            if (typeOfGoal == "Checklist goal")
            {
                timesOfAccomplishment = int.Parse(goalStringArray[3]);
                timesToAccomplish = int.Parse(goalStringArray[4]);
                bonusForAccomplishment = int.Parse(goalStringArray[5]);
            }

        }
            else
            {
                

                Console.Write("What is the name of your goal? ");
                nameOfGoal = Console.ReadLine();

                Console.Write("What is the short description of it? ");
                descriptionOfGoal = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                points = int.Parse(Console.ReadLine());

                if (typeOfGoal == "3")
                {

                    Console.Write("Howe many time does this goal need to be accomplished for a bonus? ");
                    timesToAccomplish = int.Parse(Console.ReadLine());

                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    bonusForAccomplishment = int.Parse(Console.ReadLine());
                }
            }


        if (typeOfGoal == "1" || typeOfGoal == "Simple goal")
        {
            if (goalString.Length > 0)
            {
                SimpleGoal simpleGoal = new SimpleGoal(nameOfGoal, descriptionOfGoal, points, completionStatus);
                _goals.Add(simpleGoal);
            }
            else
            {
                 SimpleGoal simpleGoal = new SimpleGoal(nameOfGoal, descriptionOfGoal, points);
                _goals.Add(simpleGoal);   
            }     
        }
        else if (typeOfGoal == "2" || typeOfGoal == "Eternal goal")
        {
            EternalGoal eternalGoal = new EternalGoal(nameOfGoal, descriptionOfGoal, points);

            _goals.Add(eternalGoal);
        }
        else if (typeOfGoal == "3" || typeOfGoal == "Checklist goal")
        {
            ChecklistGoal checklistGoal = new ChecklistGoal(nameOfGoal, descriptionOfGoal, points, timesOfAccomplishment, timesToAccomplish, bonusForAccomplishment);

            _goals.Add(checklistGoal);
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

    public void DisplayNewGoalCreationMenuAndGetUserChoice()
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

    public void DisplayGoalsList(bool toRecordEvent = false)
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine();
            Console.Write($"You have no goals yet.");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("The goals are:");

            for (int i = 0; i < _goals.Count; i++)
            {
                Console.Write($"{i + 1}. ");
                if (toRecordEvent)
                {
                    Console.WriteLine($"{_goals[i].GetNameOfGoal()}");
                }
                else
                {
                    Console.WriteLine($"{_goals[i].GetDetailsString()}");
                }
                Console.WriteLine();
            }
        }

        DisplayScore(_score);
    }

    public void SaveGoals(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);

            for (int i = 0; i < _goals.Count; i++)
            {
                outputFile.WriteLine(_goals[i].GetStringRepresentation());
            }
        }        
    }

    public void LoadGoals(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        SetOrUpdateScore(int.Parse(lines[0]));

        for (int i = 1; i < lines.Length; i++)
        {
            string[] goal = lines[i].Split(": ");

            CreateGoal(goal[0], goal[1]);
        }
    }

    public string GetFileNameFromUser()
    {
        Console.Write("What is the file name for the goal file? ");
        string fileName = Console.ReadLine();
        return fileName;
    }

    public void RecordEvent()
    {
        DisplayGoalsList(true);
        Console.Write("Which goal did you accomplish? ");
        int accomplishedGoalNumber = int.Parse(Console.ReadLine());
        _goals[accomplishedGoalNumber - 1].RecordEvent();
        Console.Write($"Congratulations! You have earned {_goals[accomplishedGoalNumber - 1].GetAmountOfPoints()} points!");
        SetOrUpdateScore(_goals[accomplishedGoalNumber - 1].GetAmountOfPoints());
        DisplayScore(GetScore(), true);
        
        
    }   

    public void ProcessingUserChoice(string choice)
    {
        switch (int.Parse(choice))
        {
            case 1:
                DisplayNewGoalCreationMenuAndGetUserChoice();
                break;
            case 2:
                DisplayGoalsList();
                break;
            case 3:
                SaveGoals(GetFileNameFromUser());
                Console.Clear();
                break;
            case 4:
                LoadGoals(GetFileNameFromUser());
                //Console.Clear();
                break;
            case 5:
                RecordEvent();
                break;
            case 6:

                Console.Clear();
                break;
        }
    }
}