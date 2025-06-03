

public class StationaryBicycleRiding : Activity
{
    private int _speedInKilometersPerHour;

    public StationaryBicycleRiding(string date, int length, int speed) : Base (date, length)
    {
        _speedInKilometersPerHour = speed;
    }

    public override int DistanceInKilometers()
    {
        return _SpeedInKilometersPerHour / 60 * GetLengthOfActivityInMinutes();
    }


    public override int PaceInMinutesPerKilometer()
    {
        return _lengthOfActivityInMinutes / DistanceInKilometers();
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Riding a stationary bicycle ({GetLengthOfActivityInMinutes()} min): Distance {DistanceInKilometers()} km, Speed: {_speedInKilometersPerHour} kph, Pace: {PaceInMinutesPerKilometer()} min per km";
    }
}