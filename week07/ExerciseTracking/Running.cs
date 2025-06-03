

public class Running : Activity
{
    
    private int _distanceInKilometers;

    public Running(string date, int length, int distance) : base (date, length)
    {
        _distanceInKilometers = distance;
    }

    public virtual double GetDistanceInKilometers()
    {
        return _distanceInKilometers;
    }

    public override double SpeedInKilometersPerHour(){
        
        return Math.Round((double)_distanceInKilometers / GetLengthOfActivityInMinutes() * 60);
    }

    public override double PaceInMinutesPerKilometer()
    {
        return Math.Round((double)GetLengthOfActivityInMinutes() / _distanceInKilometers);
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetLengthOfActivityInMinutes()} min): Distance {_distanceInKilometers} km, Speed: {SpeedInKilometersPerHour()} kph, Pace: {PaceInMinutesPerKilometer()} min per km";
    }

}