public class Scripture
{

    private List<Word> _words = new List<Word>();

    private Reference _reference = new Reference();

    public Scripture() { }

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        // Split the text into individual words and add them to the list
        foreach (var wordText in text.Split(' '))
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        string text = "";
        return text;
    }

    public bool IsCompletelyHidden()
    {
        bool boolVal = true;
        return boolVal;
    }

}