using System;


public abstract class Activity
{
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

    public abstract double DistanceInKilometers();

    public abstract double SpeedInKilometersPerHour();

    public abstract double PaceInMinutesPerKilometer();

    public abstract string GetSummary();


}