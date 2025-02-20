public class Cycling : Activity
{
    public Cycling() { }
    public Cycling(string date, int duration, double speed) : base(date, duration)
    {
        _date = date;
        _duration = duration;
        _speed = speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
}