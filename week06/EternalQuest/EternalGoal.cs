public class EternalGoal : Goal
{
    public EternalGoal() { }
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
}