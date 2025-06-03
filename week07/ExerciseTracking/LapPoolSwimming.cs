

public class LapPoolSwimming : Activity
{
    private int _numberOfLaps;
    private int _lengthOfLap;

    public LapPoolSwimming(string date, int length, int laps) : Base (date, length)
    {
        _numberOfLaps = laps;
        _lengthOfLapInMeters = 0,05;
    }

    public override int DistanceInKilometers(){
        return _numberOfLaps * _lengthOfLapInMeters / 1000;
    }

    public override int SpeedInKilometersPerHour()
    {
        return DistanceInKilometers() / GetLengthOfActivityInMinutes() * 60;
    }

    public override int PaceInMinutesPerKilometer()
    {
        return 60 / SpeedInKilometersPerHour();
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetLengthOfActivityInMinutes()} min): Distance {DistanceInKilometers()} km, Speed: {SpeedInKilometersPerHour()} kph, Pace: {PaceInMinutesPerKilometer()} min per km";
    }
}