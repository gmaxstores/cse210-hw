using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Show()
    {
        if (_isHidden == true)
        {
            _isHidden = false;
        }
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        if (_text == "_")
        {
            _isHidden = true;
        }
        else
        {
            _isHidden = false;
        }
        return _isHidden;
    }

    public string GetDisplayWord()
    {
        if (_isHidden == true)
        {
            return _text = "_";
        }
        else
        {
            return _text;
        }
    }
}