public class Activity
{
    public int _duration;
    public string _date;
    public double _speed;
    public int _laps;
    public double _distance;
    public double _pace;
    public Activity() { }
    public Activity(string date, int duration)
    {
        _duration = duration;
        _date = date;
    }

    public virtual double GetDistance()
    {
        return _distance;
    }
    public virtual double GetSpeed()
    {
        return _speed;
    }
    public virtual double GetPace()
    {
        return _pace;
    }

}