using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Console.Write("What is the magic number? ");

        string stringMagicNumber = Console.ReadLine();

        int intMagicNumberFromUser = int.Parse(stringMagicNumber);

        string stringUserGuess;
        int intUserGuess;

        do
        {
            Console.Write("What is your guess? ");

            stringUserGuess = Console.ReadLine();

            intUserGuess = int.Parse(stringUserGuess);

            if(intMagicNumberFromUser > intUserGuess)
            {
                Console.WriteLine("Higher");
            } 
            else if(intMagicNumberFromUser < intUserGuess)
            {
                Console.WriteLine("Lower");
            }
        }while(intMagicNumberFromUser != intUserGuess);

        Console.WriteLine("You guessed it!");
    }
}