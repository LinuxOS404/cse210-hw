public class Reception : Event
{
private string rsvpEmail;

    public string ReceptionDetails()
    {
     return $"{EventDetails()}: {rsvpEmail}";  
    }

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail): base(title,description,date,time,address)
    {
     this.rsvpEmail = rsvpEmail;
    }
    public string GetMessages()
    {
      return $"\n{GetDescription()}\n\n{GetDetails()}\n\n{GetShortDescription()}";
    }
    public string GetDescription()
    {
      return $"Event Type:Reception\nTitle:{title}\nDate:{date}\n{time}\n{address}\n";
    }
    public string GetDetails()
  {
   return $"Event Type:Reception\nTitle:{title}\nDate:{date}\nrsvp:{rsvpEmail}"; 
  }

  public string GetShortDescription()
  {
   return $"Event Type:Reception\nTitle:{title}\nDate:{date}"; 
  }
}











