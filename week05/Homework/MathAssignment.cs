

public class MathAssignment : Assignment
{
    private string _textBookSection;
    private List<string> _problems;

    public MathAssignment(string name, string topic, string bookSection, List<string> problems) : base(name, topic)
    {
        _textBookSection = bookSection;
        _problems = problems;
    }

    public void GetHomeworkList()
    {
        Console.WriteLine($"Section {_textBookSection} Problems {string.Join(", ", _problems)}");
    }
}