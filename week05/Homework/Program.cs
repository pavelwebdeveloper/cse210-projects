using System;

// Used resources
// https://learn.microsoft.com/en-us/dotnet/api/system.string.join?view=net-9.0

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");

        Console.WriteLine();
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();

        List<string> problems = new List<string>();

        problems.Add("3-10");
        problems.Add("20-21");

        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", problems);

        Console.WriteLine(mathAssignment.GetSummary());
        mathAssignment.GetHomeworkList();
        Console.WriteLine();

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

        Console.WriteLine(writingAssignment.GetSummary());
        writingAssignment.GetWritingInformation();
    }
}