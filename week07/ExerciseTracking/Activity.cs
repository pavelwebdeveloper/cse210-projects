using System;


public abstract class Activity
{
    //private static DateTime _dateObject = new DateTime();
    private string _date;
    private int _lengthOfActivityInMinutes;
    

    public Activity(string date, int length)
    {
        _date = date;
        _lengthOfActivityInMinutes = length;
    }

    public int GetLengthOfActivityInMinutes()
    {
        return _lengthOfActivityInMinutes;
    }

    public string GetDate()
    {
        return _date;
    }

    public virtual double DistanceInKilometers()
    {
        return 0;
    }

    public virtual double SpeedInKilometersPerHour()
    {
        return 0;
    }

    public abstract double PaceInMinutesPerKilometer();

    public abstract string GetSummary();


}