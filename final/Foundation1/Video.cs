using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;

class Video
{
   private List<Comment> comments = new List<Comment>();
  private string title;
  private string author;

  private int length;//in seconds

  public Video(string title, string author, int length)
    {
        this.title = title;
        this.author = author;
        this.length = length;//in seconds
    }

    public void AddComment(Comment comment )
    {
      comments.Add(comment);
    }
    
    public void DisplayVideoInfo()
    {
      Console.WriteLine($"Title:{title}");
      Console.WriteLine($"Author:{author}");
      Console.WriteLine($"Length in seconds:{length}");  

    foreach(var comment in comments)
    {
     Console.WriteLine($"{comment.GetName()} {comment.GetText()}");       
    }      
    }

    






}

