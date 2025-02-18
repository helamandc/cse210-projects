public class ReflectingActivity : Activity
{
    public List<string> _prompts = new List<string>();
    public List<string> _questions = new List<string>();

    public ReflectingActivity() { }

    public ReflectingActivity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void run()
    {
        Console.WriteLine("Get ready...\n");
    }

    public string GetRandomPrompt()
    {
        string test = "";
        return test;
    }

    public string GetRandomQuestion()
    {
        string test = "";
        return test;
    }

    public void DisplayPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string randomItem = _prompts[randomIndex];
        Console.WriteLine(randomItem);
    }

    public void DisplayQuestions()
    {
        Random random = new Random();
        int randomIndex = random.Next(_questions.Count);
        string randomItem = _questions[randomIndex];
        Console.WriteLine(randomItem);
    }

}