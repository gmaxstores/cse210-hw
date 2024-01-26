using System.IO;

using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference refer, string text)
    {
        List<Word> wordss = new List<Word>();
        _reference = refer;
        List<string> words = text.Split(" ").ToList();
        foreach (string word in words)
        {
            Word newWord = new Word(word);
            wordss.Add(newWord);
            _words = wordss;
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        
        Word woord = _words[numberToHide];
        foreach (Word a in _words)
        {
            if (a == _words[numberToHide] && a.IsHidden() == false)
            {
                a.Hide();
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(Word => Word.IsHidden());
    }

    public string GetDisplayTextt()
    {
        List<string> sentList = new List<string>();
        foreach (Word p in _words)
        {
            sentList.Add(p.GetDisplayWord());
        }
        string sentence = String.Join(" ", sentList);
        return sentence;
    }

    public List<Word> Getters()
    {
        return _words;
    }
}