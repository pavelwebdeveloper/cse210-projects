

public class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    public void GetDisplayText()
    {
        Console.Write($"{_word}");
    }

    public string GetWord()
    {
        return _word;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public void Hide()
    {
        if(_hidden == false)
        {
            string newWord = "";
            for(int i = 0; i <= _word.Length; i++)
            {
                newWord += "_";
            }   
            _word = newWord;
            _hidden = true;

        }    
    }
}