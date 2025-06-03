

public class StationaryBicycleRiding : Activity
{
    private int _speedInKilometersPerHour;

    public StationaryBicycleRiding(string date, int length, int speed) : base (date, length)
    {
        _speedInKilometersPerHour = speed;
    }

    public override double DistanceInKilometers()
    {
        return Math.Round((double)_speedInKilometersPerHour / 60 * GetLengthOfActivityInMinutes());
    }

    public override double SpeedInKilometersPerHour()
    {
        return _speedInKilometersPerHour;
    }


    public override double PaceInMinutesPerKilometer()
    {
        return Math.Round((double)GetLengthOfActivityInMinutes() / DistanceInKilometers());
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Riding a stationary bicycle ({GetLengthOfActivityInMinutes()} min): Distance {DistanceInKilometers()} km, Speed: {SpeedInKilometersPerHour()} kph, Pace: {PaceInMinutesPerKilometer()} min per km";
    }
}