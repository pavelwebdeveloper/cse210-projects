

public class Running : Activity
{
    
    private int _distanceInKilometers;

    public Running(string date, int length, int distance) : base (date, length)
    {
        _distanceInKilometers = distance;
    }

    public override double DistanceInKilometers()
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
        return $"{GetDate()} Running ({GetLengthOfActivityInMinutes()} min): Distance {DistanceInKilometers()} km, Speed: {SpeedInKilometersPerHour()} kph, Pace: {PaceInMinutesPerKilometer()} min per km";
    }

}