using System;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _listOfComments;
    public Video(string title, string author, int length)
    {
        List<Comment> listOfComments = new List<Comment>();
        _listOfComments = listOfComments;
        _length = length;
        _title = title;
        _author = author;
    }
    public void AddComment(Comment newComment)
    {
        _listOfComments.Add(newComment);
    }
    public int GetCommentCount()
    {
        int commentCount = _listOfComments.Count();
        return commentCount;
    }
    public void DisplayInformation()
    {
        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nLength: {_length} seconds");
        if (_listOfComments.Count() != 0)
        {
            Console.WriteLine($"Comment Count: {GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach(Comment comment in _listOfComments)
            {
                comment.DisplayComment();
            }
        }
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("========================================================================================\n");
        Console.ResetColor();
    }
}