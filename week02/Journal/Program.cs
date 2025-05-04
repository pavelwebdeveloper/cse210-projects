using System;
using System.IO;
using System.Transactions;

// Resources used:
// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers
// https://learn.microsoft.com/en-us/dotnet/api/system.random.next?view=net-9.0#system-random-next
// https://www.w3schools.com/cs/cs_switch.php


class Program
{
    static void ShowMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
    }

    static void ProcessAnswer(int answer, Journal journal)
    {
        switch(answer)
        {
            case 1:
                Entry entry = new Entry();
                DateTime dateTime = DateTime.Now;
                entry._date = dateTime.ToShortDateString();
                PromptGenerator promptGenerator = new PromptGenerator();
                entry._prompt = promptGenerator.GetRandomPrompt();
                entry._text = Console.ReadLine();
                journal.AddEntry(entry);
            break;
            case 2:
                if(journal._entries.Count == 0 && answer == 2)
                {
                    // this code exceeds the core requirements and shows some messages if 
                    // the program does not have any entries to display yet
                    Console.WriteLine();
                    Console.WriteLine("Sorry, no entries to display yet.");
                    Console.WriteLine("Please, either input an entry or load from a file.");
                    Console.WriteLine();
                } else 
                {
                    journal.DisplayAll();
                }
                
            break;
            case 3:
                Console.WriteLine("What is the file name?");
                string loadFileName = Console.ReadLine();
                journal.LoadFromFile(loadFileName);
            break;
            case 4:
                Console.WriteLine("What is the file name?");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            break;
            case 5:
            break;
        }
    }


    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Journal Program!");
        Journal journal = new Journal();
        string answer;
        int intAnswer = 0;
        do
        {
        ShowMenu();
        answer = Console.ReadLine();
        if(answer == "1" || answer == "2" || answer == "3" || answer == "4" || answer == "5")
            {
                intAnswer = int.Parse(answer);
                ProcessAnswer(intAnswer, journal);
            } else 
            {
                // This code exceeds the core requirements and displays a message if a user
                // entered something other than the numbers 1 through 5
                    Console.WriteLine();
                    Console.WriteLine("Please, enter an intiger between 1 and 5");
                    Console.WriteLine();
            }
        }while(intAnswer != 5);
    }
}