using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomNumberObject = new Random();
        string answerFromUser = "yes";
        int magicNumber;
        string stringUserGuess;
        int intUserGuess;
        int numberOfGuesses = 0;

        while(answerFromUser == "yes")
        {
            magicNumber = randomNumberObject.Next(1, 100);

            do
            {
                Console.Write("What is your guess for a magic number? ");

                stringUserGuess = Console.ReadLine();

                intUserGuess = int.Parse(stringUserGuess);

                numberOfGuesses++;

                if(magicNumber > intUserGuess)
                {
                    Console.WriteLine("Higher");
                } 
                else if(magicNumber < intUserGuess)
                {
                    Console.WriteLine("Lower");
                }
            }while(magicNumber != intUserGuess);

            Console.WriteLine($"You guessed it after {numberOfGuesses} guesses!");
            Console.Write("Do you want to play again? ");
            answerFromUser = Console.ReadLine();
        }
    }
}