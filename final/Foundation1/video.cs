using System;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _list_of_comments;
    Video(int length)
    {}
    public void AddComment(string newComment)
    {
        Console.WriteLine();
    }
    public int GetCommentCount()
    {
        int commentCount = _list_of_comments.Count();
        return commentCount;
    }
    public void DisplayInformation()
    {
        Console.WriteLine();
    }
}