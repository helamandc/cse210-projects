using System;
class Program
{
    static void Main(string[] args)
    {
        SimpleGoal simple = new SimpleGoal();
        EternalGoal eternal = new EternalGoal();
        ChecklistGoal checklist = new ChecklistGoal();
        GoalManager goalList = new GoalManager();
        string score = goalList._score.ToString();
        string choice = "";
        string goal = "";
        int goalAchieved;
        string goalFile = "";
        do
        {
            Console.WriteLine($"You have {score} points.");
            Console.WriteLine("Menu Options:\n 1. Create a new goal.\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("The types of Goals are:\n 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal");
                Console.WriteLine("Which type of goal would you like to create?");
                goal = Console.ReadLine();
                if (goal == "1")
                {
                    Console.WriteLine("What is the name of your goal?");
                    simple._shortName = Console.ReadLine();
                    Console.WriteLine("What is a short description of it?");
                    simple._description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal?");
                    simple._points = Console.ReadLine();
                    goalList._goals.Add(simple);
                }
                else if (goal == "2")
                {
                    Console.WriteLine("What is the name of your goal?");
                    eternal._shortName = Console.ReadLine();
                    Console.WriteLine("What is a short description of it?");
                    eternal._description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal?");
                    eternal._points = Console.ReadLine();
                    goalList._goals.Add(eternal);

                }
                else
                {
                    Console.WriteLine("What is the name of your goal?");
                    checklist._shortName = Console.ReadLine();
                    Console.WriteLine("What is a short description of it?");
                    checklist._description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal?");
                    checklist._points = Console.ReadLine();
                    Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
                    checklist._target = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the bonus for accomplishing it that many times?");
                    checklist._bonus = int.Parse(Console.ReadLine());
                    goalList._goals.Add(checklist);

                }
            }
            else if (choice == "2")
            {
                Console.WriteLine("The goals are:");
                goalList.ListGoalDetails();
            }
            else if (choice == "3")
            {
                Console.WriteLine("What is the filename for the goal file?");
                goalFile = Console.ReadLine();
                goalList.SaveGoals(goalFile);
            }
            else if (choice == "4")
            {
                Console.WriteLine("What is the filename for the goal file?");
                goalFile = Console.ReadLine();
                goalList.LoadGoals(goalFile);
            }
            else if (choice == "5")
            {
                Console.WriteLine("The goals are:");
                goalList.ListGoalDetails();
                Console.WriteLine("Which goal did you accomplish? ");
                goalAchieved = int.Parse(Console.ReadLine());
                Console.WriteLine($"Congratulatios! You have earned {goalAchieved} points!");
                Console.WriteLine($"You now have {goalAchieved} points!");
                Console.WriteLine($"You have {goalAchieved} points!");
            }
        } while (choice != "6");
        Environment.Exit(0);
    }
}