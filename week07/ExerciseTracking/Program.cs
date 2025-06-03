using System;
using System.Globalization;

// Used resources
// https://stackoverflow.com/questions/8711390/get-the-complete-month-name-in-english
// https://stackoverflow.com/questions/48957699/percentage-calculation-always-returns-me-0
// https://forum.uipath.com/t/how-to-round-a-double-variable-only-have-to-decimal-places/519926/5

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");


        List<Activity> _activities = new List<Activity>();



        DateTime date = DateTime.Now;
        CultureInfo culture = new CultureInfo("en-US");

        _activities.Add(new Running(date.ToString("dd MMMM yyyy", culture), 20, 3));
        _activities.Add(new StationaryBicycleRiding(date.ToString("dd MMMM yyyy", culture), 60, 15));
        _activities.Add(new LapPoolSwimming(date.ToString("dd MMMM yyyy", culture), 10, 30));

        Console.WriteLine();
        foreach (Activity activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
        Console.WriteLine();
    }
}