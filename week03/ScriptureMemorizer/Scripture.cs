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
        string input = GetDisplayText();

        // Split the input string into words
        var words = input.Split(' ').ToList();

        // Exclude the first two words
        var wordsToConsider = words.Skip(2).ToList();

        // Randomly select words to replace
        Random random = new Random();
        var wordsToReplace = wordsToConsider.OrderBy(x => random.Next()).Take(numberToHide).ToList();

        // Replace letters in the selected words with underscores
        foreach (var word in wordsToReplace)
        {
            string underscores = new string('_', word.Length);
            input = input.Replace(word, underscores);
        }

        Console.Write(input);
    }

    public string GetDisplayText()
    {
        List<string> wordTexts = new List<string>();

        foreach (var word in _words)
        {
            wordTexts.Add(word.GetDisplayText());
        }

        string text = string.Join(" ", wordTexts);

        string texts = _reference.GetDisplayTextVerses() + " " + text;
        return texts;
    }

    public bool IsCompletelyHidden()
    {
        bool boolVal = true;
        return boolVal;
    }

}