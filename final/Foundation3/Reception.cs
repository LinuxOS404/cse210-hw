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
public string GetDescription()
    {
      return $"Event Type: Reception\nTitle:{title}\nDate:{date}\nRSVP:{rsvpEmail} ";
    }











}