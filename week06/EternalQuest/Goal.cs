public class Goal
{
    public string _shortName = "";
    public string _description = "";
    public string _points = "0";
    public Goal() { }
    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public void RecordEvent() { }
    public bool IsComplete()
    {
        return true;
    }
    public string GetDetailsString()
    {
        return $"{_shortName} ({_description}) - {_points}";
    }
    public string GetStringRepresentation()
    {
        return _shortName;
    }



}