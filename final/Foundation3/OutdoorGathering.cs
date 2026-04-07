public class OutdoorGathering : Event
{

private string _weather;


    public string OutdoorEventDetails()
    {
     return $"{EventDetails()}: {_weather}"; 
    }

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string _weather): base(title,description,date,time,address)
    {
     this._weather = _weather;
    }

    public string GetMessages()
    {
      return $"\n{GetDescription()}\n\n{GetDetails()}\n\n{GetShortDescription()}";
    }
    public string GetDescription()
    {
      return $"Event Type:Outdoor Gathering\nTitle:{title}\nDate:{date}\n{time}\n{address}\n";
    }
    public string GetDetails()
  {
   return $"Event Type:Outdoor Gathering\nTitle:{title}\nDate:{date}\nSpeaker:{_weather}"; 
  }

  public string GetShortDescription()
  {
   return $"Event Type:Outdoor Gathering\nTitle:{title}\nDate:{date}"; 
  }
}















