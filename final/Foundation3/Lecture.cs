public class Lecture : Event
{
private string _speaker;
 private int _capacity;

    public string LectureDetails()
    {
     return $"{EventDetails()}: {_speaker}: {_capacity}";  
    }

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity): base(title,description,date,time,address)
    {
     this._speaker = _speaker;
     this._capacity = _capacity;
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
   return $"Event Type:Lecture\nTitle:{title}\nDate:{date}\nSpeaker:{_speaker}\nCapacity:{_capacity}"; 
  }

  public string GetShortDescription()
  {
   return $"Event Type:Lecture\nTitle:{title}\nDate:{date}"; 
  }
}



















