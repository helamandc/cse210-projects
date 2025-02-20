public class GoalManager : Goal
{
    public List<Goal> _goals = new List<Goal>();
    public int _score = 0;
    public GoalManager() { }
    public void Start() { }
    public void DisplayPlayerInfo() { }
    public void ListGoalNames() { }
    public void ListGoalDetails()
    {
        int i = 1;
        foreach (Goal goal in _goals)
        {

            Console.WriteLine($"{i}. [] {goal._shortName} ({goal._description})");
            i++;
        }
    }
    public void CreateGoal() { }
    public void SaveGoals(string fileNameSave)
    {
        string filePath = $"C:\\Users\\manle\\Desktop\\{fileNameSave}";

        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Goal goal in _goals)
                {
                    writer.WriteLine(goal.GetDetailsString());
                }
            }
        }
        //Exceeding requirements by adding an exception if for it failed to load from file
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
        }
    }
    public void LoadGoals(string fileNameLoad)
    {
        string filePath = $"C:\\Users\\manle\\Desktop\\{fileNameLoad}";

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        //Exceeding requirements by adding an exception if for it failed to load from file
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
        }
    }
}