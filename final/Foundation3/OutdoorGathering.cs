public class OutdoorGathering : Event
{

private string weather;


    public string OutdoorEventDetails()
    {
     return $"{EventDetails()}: {weather}"; 
    }

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weather): base(title,description,date,time,address)
    {
     this.weather = weather;
    }

    public string GetDescription()
    {
      return $"Event Type:OutdoorGathering\nTitle:{title}\nDate:{date} \nweather:{weather} ";
    }














}