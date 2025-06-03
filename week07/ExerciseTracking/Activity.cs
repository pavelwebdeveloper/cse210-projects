using System;


public class Activity
{
    private DateTime _dateObject = new DateTime();
    //private string _date = _dateObject.;
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

    public virtual int DistanceInKilometers()
    {
        return 0;
    }

    public virtual int SpeedInKilometersPerHour()
    {
        return 0;
    }

    public abstract int PaceInMinutesPerKilometer();

    public abstract string GetSummary();


}