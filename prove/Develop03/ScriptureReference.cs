public class ScriptureReference 
{
    private string _refBook;
    private string _refChapter;
    private string _refVerse;

    public ScriptureReference(string refBook, string refChapter, string refVerse)
    {
        _refBook = refBook;
        _refChapter = refChapter;
        _refVerse = refVerse;
    }

    public string GetReference()
    {
        string scriptRef = $"{_refBook} {_refChapter}:{_refVerse}";
        return scriptRef;
    }
}