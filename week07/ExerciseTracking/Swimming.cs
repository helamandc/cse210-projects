public class Swimming : Activity
{

    public Swimming() { }
    public Swimming(string date, int duration, int laps) : base(date, duration)
    {
        _date = date;
        _duration = duration;
        _laps = laps;
    }
    public override double GetSpeed()
    {
        double numerator = _laps * 50 / 1000;
        return numerator / _duration * 60;
    }
}