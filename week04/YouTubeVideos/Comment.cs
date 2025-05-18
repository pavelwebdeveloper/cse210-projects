

public class Comment
{
    private string _nameOfPerson;
    private string _text;

    public Comment(string name, string text)
    {
        _nameOfPerson = name;
        _text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"    name: {_nameOfPerson}       comment: {_text}");
    }
}