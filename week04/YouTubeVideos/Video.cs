

public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;

    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = length;
    }

    public void AddingComment(string name, string text)
    {
        Comment comment = new Comment(name, text);
        _comments.Add(comment);
    }

    public int NumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Title of video: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length in seconds: {_lengthInSeconds}");
        Console.WriteLine($"Number of comments: {NumberOfComments()}");
        Console.WriteLine();
        if(NumberOfComments() > 0)
        {
            Console.WriteLine($"    Comments for {_title} video: ");
        }
        Console.WriteLine();
        foreach(Comment comment in _comments)
        {
            comment.DisplayComment();
            Console.WriteLine();
        }
    }
}