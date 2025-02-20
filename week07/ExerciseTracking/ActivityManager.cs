public class ActivityManager : Activity
{
    public List<Activity> _activities = new List<Activity>();
    public ActivityManager() { }
    public void GetSummary()
    {
        foreach (Activity activity in _activities)
        {
            Console.WriteLine($"{activity._date} Running ({activity._duration} min) - Distance {activity._distance} km, Speed: {activity.GetSpeed()} kph, Pace: {60 / activity.GetSpeed()} min per km");
        }
    }

}