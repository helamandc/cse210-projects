public class Fractions
{
    private int _top;
    private int _bottom;

    public Fractions()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fractions(int topNumber)
    {
        _top = topNumber;
        _bottom = 1;
    }

    public Fractions(int topNum, int bottomNum)
    {
        _top = topNum;
        _bottom = bottomNum;
    }

    public void GetFractionString()
    {
        Console.WriteLine($"{_top}/{_bottom}");
    }

    public void GetDecimalValue()
    {
        double decValue = (double)_top / (double)_bottom;
        Console.WriteLine($"{decValue}");
    }

}