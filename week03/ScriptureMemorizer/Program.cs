using System;
using System.IO;

// Used resources
// https://stackoverflow.com/questions/9263695/how-to-split-a-delimited-string-to-a-liststring
// https://learn.microsoft.com/en-us/dotnet/api/system.random.next?view=net-9.0#system-random-next

// to exceed the basic requirements I added a function which loads scriptures randomly from a file
// this function is defined and called inside this Program class

class Program
{
    static void ShowMenu(Scripture scripture)
    {
        Console.WriteLine();
        scripture.GetDisplayText();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
    }

    // this code exceeds the core requirements and loads scriptures randomly from a file
    static Scripture LoadFromFile(string fileName, Random random)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);
        string[] referenceArray;
        int i;

        do{
            i = random.Next(lines.Length);
        }while(i%2 != 0);

        referenceArray = lines[i++].Split(' ', ':', '-');
        Reference reference;
                
        if(referenceArray.Length == 3)
        {
            reference = new Reference(referenceArray[0], int.Parse(referenceArray[1]), int.Parse(referenceArray[2]));
        } else
        {
            reference = new Reference(referenceArray[0], int.Parse(referenceArray[1]), int.Parse(referenceArray[2]), int.Parse(referenceArray[3]));
        }
                    
        Scripture scripture = new Scripture (reference, lines[i]);
          
        return scripture;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        
        Random random = new Random();
        // this code exceeds the core requirements and loads scriptures randomly from a file
        Scripture scripture = LoadFromFile("scriptures.txt", random);
    
        ShowMenu(scripture);
        string answer = Console.ReadLine();
        if(answer != "quit")
        {
            while(scripture.IsCompletelyHidden() != true)
            {
            Console.Clear();
            scripture.HideRandomWords(random);
            ShowMenu(scripture);
            answer = Console.ReadLine();

                if(answer == "quit")
                {
                    break;
                }
            }
        }   
    }
}