public class Reference
{

    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference() { }

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;

    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;

    }

    public string GetDisplayTextVerse()
    {
        //Exceeding requirements: Ensuring that the first letter of the string argument provided in the constructor is always starts in uppercase
        string verse = char.ToUpper(_book[0]) + _book.Substring(1) + " " + _chapter + ":" + _verse;
        return verse;
    }

    public string GetDisplayTextVerses()
    {
        //Exceeding requirements: Ensuring that the first letter of the string argument provided in the constructor is always starts in uppercase

        string verses = char.ToUpper(_book[0]) + _book.Substring(1) + " " + _chapter + ":" + _verse + "-" + _endVerse;
        return verses;
    }

}