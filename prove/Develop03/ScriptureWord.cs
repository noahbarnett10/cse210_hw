using System.Collections.Generic;
using System;

public class Word
{
    private string _text;
    private bool _hidden;

    public Word(string Text)
    {
        _text = Text;
        _hidden = false;
    }
    public void HideWord()
    {
        _hidden = true;
    }
    public bool IsHidden()
    {
        return _hidden;
    }
    public string GetText()
    {
        return _hidden ? new string('_', _text.Length): _text;
    }

}
public class ScriptureWord
{   
    public List<Word> Words;
    public ScriptureWord(string Text)
    {
        Words = new List<Word>();
        foreach (var word in Text.Split(new[] {' '}))
        {
            Words.Add(new Word(word));
        }
    }
    public bool HideWord()
    {
        Random rand = new Random();
        List<Word> visibleWords = Words.Where(word => !word.IsHidden()).ToList();
        if (visibleWords.Count > 0)
        {
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].HideWord();
            return true;
        }
        return false;
    }

    public void Display()
    {
        foreach (var word in Words)
        {
            Console.Write(word.GetText() + " ");
        }
        Console.WriteLine();
    }
}