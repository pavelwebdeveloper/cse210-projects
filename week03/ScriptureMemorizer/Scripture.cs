

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = TransformTextIntoListOfWords(text);
    }

    private List<Word> TransformTextIntoListOfWords(string text)
    {
        string[] textArray = text.Split(" ");
        List<Word> _words = new List<Word>();
        foreach(string stringWord in textArray)
        {
            Word word = new Word(stringWord);
            _words.Add(word);
        }
        return _words;
    }

    public void HideRandomWords(Random random)
    {
        int wordsHiddenCount = 0;
        int randomNumber;

        do{
                randomNumber = random.Next(_words.Count);

                for(int i = 0; i <= _words.Count; i++)
                {
                    if(i == randomNumber)
                    {
                        if(_words[i].IsHidden() == false)
                        {
                            _words[i].Hide();
                            wordsHiddenCount++;
                        }
                    }
                }

                if(IsCompletelyHidden() == true)
                {
                    break;
                }
                
            }while(wordsHiddenCount != 3);

    }

    public bool IsCompletelyHidden()
    {
        int amountOfHiddenWords = 0;

                foreach(Word word in _words)
                {
                    if(word.IsHidden() == true)
                    {
                        amountOfHiddenWords += 1;
                    }
                }
                
                if(amountOfHiddenWords == _words.Count)
                {
                    return true;
                } else
                {
                    return false;
                }
    }

    public void GetDisplayText()
    {
        _reference.GetDisplayText();
        foreach(Word word in _words)
        {
            if(word.GetWord().Contains("."))
            {
                word.GetDisplayText();
            } else
            {
                word.GetDisplayText();
                Console.Write(" ");
            }
        }  
    }
}