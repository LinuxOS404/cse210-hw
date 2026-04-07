public class Lecture : Event
{
private string speaker;
 private int capacity;

    public string LectureDetails()
    {
     return $"{EventDetails()}: {speaker}: {capacity}";  
    }

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity): base(title,description,date,time,address)
    {
     this.speaker = speaker;
     this.capacity = capacity;
    }
    public string GetMessages()
    {
      return $"\n{GetDescription()}\n\n{GetDetails()}\n\n{GetShortDescription()}";
    }
    public string GetDescription()
    {
      return $"Event Type:Lecture\nTitle:{title}\nDate:{date}\n{time}\n{address}\n";
    }
    public string GetDetails()
  {
   return $"Event Type:Lecture\nTitle:{title}\nDate:{date}\nSpeaker:{speaker}\nCapacity:{capacity}"; 
  }

  public string GetShortDescription()
  {
   return $"Event Type:Lecture\nTitle:{title}\nDate:{date}"; 
  }
}



















