

public class LapPoolSwimming : Activity
{
    private int _numberOfLaps;
    private int _lengthOfLapInMeters;

    public LapPoolSwimming(string date, int length, int laps) : base (date, length)
    {
        _numberOfLaps = laps;
        _lengthOfLapInMeters = 50;
    }

    public override double DistanceInKilometers(){
        return _numberOfLaps * _lengthOfLapInMeters / 1000;
    }

    public override double SpeedInKilometersPerHour()
    {
        return Math.Round((double)DistanceInKilometers() / GetLengthOfActivityInMinutes() * 60);
    }

    public override double PaceInMinutesPerKilometer()
    {
        return Math.Round((double)60 / SpeedInKilometersPerHour());
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetLengthOfActivityInMinutes()} min): Distance {DistanceInKilometers()} km, Speed: {SpeedInKilometersPerHour()} kph, Pace: {PaceInMinutesPerKilometer()} min per km";
    }
}