using System;

class Program
{
    //Author: Helaman Del Castillo - Exercise Tracking Program
    static void Main(string[] args)
    {
        ActivityManager activityList = new ActivityManager() { };
        Running run = new Running("03 Nov 2022", 30, 4.8) { };
        Cycling cycle = new Cycling("03 Nov 2022", 30, 120) { };
        Swimming swim = new Swimming("03 Nov 2022", 30, 60) { };


        Console.WriteLine($"{run._date} Running ({run._duration} min) - Distance {run._distance} km, Speed: {run.GetSpeed()} kph, Pace: {60 / run.GetSpeed()} min per km");

        Console.WriteLine($"{cycle._date} Cycling ({cycle._duration} min) - Distance {cycle._duration / cycle.GetPace()} km, Speed: {cycle._speed} kph, Pace: {cycle.GetPace()} min per km");

        Console.WriteLine($"{swim._date} Swimming ({swim._duration} min) - Distance {swim._laps * 50 / 1000} km, Speed: {swim.GetSpeed()} kph, Pace: {60 / swim.GetSpeed()} min per km");

        activityList._activities.Add(run);
        activityList._activities.Add(cycle);
        activityList._activities.Add(swim);

        activityList.GetSummary();//Unable to display correct list of activities
    }
}