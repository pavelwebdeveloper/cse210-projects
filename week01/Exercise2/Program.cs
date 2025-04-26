using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        string stringGradePercentage = Console.ReadLine();
        int numberGradePercentage = int.Parse(stringGradePercentage);

        string letter;

        string sign = "";

        if (numberGradePercentage >= 90)
        {
            letter = "A";
            if(numberGradePercentage % 10 < 3)
            {
                sign = "-";
            }
        } 
        else if (numberGradePercentage >= 80)
        {
            letter = "B";
            if(numberGradePercentage % 10 >= 7)
            {
                sign = "+";
            }
            else if (numberGradePercentage % 10 < 3)
            {
                sign = "-";
            }
        }
        else if (numberGradePercentage >= 70)
        {
            letter = "C";
            if(numberGradePercentage % 10 >= 7)
            {
                sign = "+";
            }
            else if (numberGradePercentage % 10 < 3)
            {
                sign = "-";
            }
        }
        else if (numberGradePercentage >= 60)
        {
            letter = "D";
            if(numberGradePercentage % 10 >= 7)
            {
                sign = "+";
            }
            else if (numberGradePercentage % 10 < 3)
            {
                sign = "-";
            }
        }
        else
        {
            letter ="F";
        }

        Console.WriteLine($"Your grade is {letter}{sign}");

        if(numberGradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You have passed the class!");
        }
        else
        {
           Console.WriteLine("Sorry but you got a failing grade. Please, try to take the class again."); 
        }
    }
}