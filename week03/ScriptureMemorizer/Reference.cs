

public class Reference
{
    private string _book;
    private int _chapter;
    private int _startingVerse;
    private int _endingVerse;

    public Reference(string bookName, int chapter, int singleVerse)
    {
        _book = bookName;
        _chapter = chapter;
        _startingVerse = singleVerse;
        _endingVerse = 0;
    }

    public Reference(string bookName, int chapter, int startVerse, int endVerse)
    {
        _book = bookName;
        _chapter = chapter;
        _startingVerse = startVerse;
        _endingVerse = endVerse;
    }

    public void GetDisplayText()
    {
        if(_endingVerse > 0)
        {
            Console.Write($"{_book} {_chapter}:{_startingVerse}-{_endingVerse} ");
        } else
        {
            Console.Write($"{_book} {_chapter}:{_startingVerse} ");
        }
    }
}