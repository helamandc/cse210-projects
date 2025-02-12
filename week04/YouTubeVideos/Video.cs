public class Video
{

    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments1 = new List<Comment>();
    public List<Comment> _comments2 = new List<Comment>();
    public List<Comment> _comments3 = new List<Comment>();

    public Video() { }

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"{_title}: {_author} ({_length} seconds)");
    }

    public int CountComments1()
    {
        int count = _comments1.Count();
        return count;
    }
    public void DisplayVideoLists1()
    {
        int currentIndex = 0;
        foreach (Comment comments in _comments1)
        {
            if (currentIndex < _comments1.Count() - 1)
            {
                comments.GetDisplayComment();
            }
            currentIndex++;
        }
    }



    public int CountComments2()
    {
        int count = _comments2.Count();
        return count;
    }
    public void DisplayVideoLists2()
    {
        foreach (Comment comments in _comments2)
        {
            comments.GetDisplayComment();
        }
    }
    public int CountComments3()
    {
        int count = _comments3.Count();
        return count;
    }
    public void DisplayVideoLists3()
    {
        foreach (Comment comments in _comments3)
        {
            comments.GetDisplayComment();
        }
    }

}