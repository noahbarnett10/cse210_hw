public class ScriptureText
{
    // Use getters to grab reference and verse? 
    private ScriptureReference _reference;
    private ScriptureWord _scriptureWords;

    public ScriptureText(string book, string chapter, string verses, string text)
    {
        _reference = new ScriptureReference(book, chapter, verses);
        _scriptureWords = new ScriptureWord(text);

    }

    public void DisplayReference()
    {
        Console.WriteLine(_reference.GetReference());
    }

    public bool HideWords(int count)
    {
        int wordsToHide = Math.Min(count, _scriptureWords.Words.Count(word => !word.IsHidden()));

        if (wordsToHide == 0)
        {
            return false;
        }

        for (int i = 0; i < wordsToHide; i++)
        {
            _scriptureWords.HideWord();
        }
    return true;
    }

    public void DisplayScripture()
    {
        _scriptureWords.Display();
    }

}