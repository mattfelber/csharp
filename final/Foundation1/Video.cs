using System.Transactions;

public class Video 
{

    public string Title {get;set;}
    public string Author {get;set;}
    public int Length {get;set;}


    public List<Comment> comments; //stores comments in a list

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        comments = new List<Comment>();
        
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }
}