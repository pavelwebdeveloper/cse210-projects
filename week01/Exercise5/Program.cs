using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: Brother ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string stringFavoriteNumber = Console.ReadLine();
        int favoriteNumber = int.Parse(stringFavoriteNumber);
        return favoriteNumber;
    }

    static int SquareNumber(int number)
    {
        int squaredNumber = number * number;
        return squaredNumber;
    }

    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"Brother {name}, the square of your number is {number}");
    }
    

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        string name;
        int number;
        int squareOfNumber;

        DisplayWelcome();

        name = PromptUserName();
        number = PromptUserNumber();
        squareOfNumber = SquareNumber(number);
        DisplayResult(name, squareOfNumber);

    }
}