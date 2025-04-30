using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "EPAM";
        job1._startYear = 2015;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Developer";
        job2._company = "Luxsoft";
        job2._startYear = 2020;
        job2._endYear = 2023;


        Resume resume = new Resume();
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
        
    }
}