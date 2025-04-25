using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbersFromUser = new List<int>();

        string stringNumber;
        int number;
        double sum = 0;
        double average;
        int maxValue = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            stringNumber = Console.ReadLine();
            number = int.Parse(stringNumber);
            if(number != 0)
            {
                numbersFromUser.Add(number);
            }
        }while(number != 0);

        foreach(int listNumber in numbersFromUser)
        {
            sum+=listNumber;
            
            if(listNumber > maxValue)
            {
                maxValue = listNumber;
            }
        }

        average = sum/numbersFromUser.Count;


        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxValue}");
    }
}