public class ListingActivity : Activity
{
    public int _count;
    public List<string> _prompt = new List<string>();
    public List<string> _items = new List<string>();

    public ListingActivity() { }

    public ListingActivity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void run()
    {
        Console.WriteLine("Get ready...\n");
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompt.Count);
        string randomItem = _prompt[randomIndex];
        Console.WriteLine(randomItem);
    }

    public List<string> GetListFromUser()
    {
        return _prompt;
    }
}