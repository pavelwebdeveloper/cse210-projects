using System;
using System.IO;

// Resources used:
// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers
// https://learn.microsoft.com/en-us/dotnet/api/system.random.next?view=net-9.0#system-random-next
// https://www.w3schools.com/cs/cs_switch.php

class Program
{
    static void ShowMenu()
    {
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
        
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal journal = new Journal();
        int answer;
        do
        {
        ShowMenu();
        answer = int.Parse(Console.ReadLine());
        ProcessAnswer(answer, journal);
        }while(answer != 5);
    }
}