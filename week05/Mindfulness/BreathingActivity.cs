public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void run()
    {
        Console.WriteLine("Get ready...\n");
    }
}