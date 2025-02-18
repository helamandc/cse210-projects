using System.Security.Principal;

public class Activity
{
    public string _name;
    public string _description;
    public int _duration;

    // public Activity(string name, string desc, int duration)
    // {
    //     _name = name;
    //     _description = desc;
    //     _duration = duration;
    // }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.\n\n{_description}");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!!\n\nYou have completed another {_duration} seconds of the {_name}.");
    }

    public void ShowSpinner(int seconds)
    {
        _duration = seconds;
        Console.WriteLine(_duration);
    }

    public void ShowCountDown(int seconds)
    {
        _duration = seconds;
        Console.WriteLine(_duration);
    }
}