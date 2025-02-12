public class Comment
{

    public string _name;
    public string _comment;

    public Comment() { }

    public void GetDisplayComment()
    {
        Console.WriteLine($"{_name}: {_comment}");
    }


}