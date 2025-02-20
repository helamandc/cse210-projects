public class Running : Activity
{

    public Running() { }
    public Running(string date, int duration, double distance) : base(date, duration)
    {
        _date = date;
        _duration = duration;
        _distance = distance;
    }
    public override double GetSpeed()
    {
        return 60 * _distance / _duration;
    }
}