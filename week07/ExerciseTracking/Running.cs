

public class Running : Activity
{
    
    private int _distanceInKilometers;

    public Running(string date, int length, int distance) : Base (date, length)
    {
        _distanceInKilometers = distance;
    }

    public virtual int GetDistanceInKilometers()
    {
        return _distanceInKilometers;
    }

    public override int SpeedInKilometersPerHour(){
        return _distanceInKilometers / GetLengthOfActivityInMinutes() * 60;
    }

    public override int PaceInMinutesPerKilometer()
    {
        return _lengthOfActivityInMinutes / _distanceInKilometers;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetLengthOfActivityInMinutes()} min): Distance {_distanceInKilometers} km, Speed: {SpeedInKilometersPerHour()} kph, Pace: {PaceInMinutesPerKilometer()} min per km";
    }

}