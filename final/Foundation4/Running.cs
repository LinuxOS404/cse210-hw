class Running : Activity
{

private float _distance;

public Running(DateOnly date, int minutes,float distance) : base(date,minutes)
    {
      this._distance = _distance;  

    }
    

   public override float GetSpeed()
    {
      return _distance/GetMinutes() * 60;  
    }

    public override float GetPace()
    {
      return GetMinutes()/_distance;  
    }

    public override float GetDistance()
    {
      return _distance;  
    }
    public override string GetSummary()
    {
      return $"This is running - Date:{_date}|Minutes:{GetMinutes()}|Distance:{GetDistance()}|Speed:{GetSpeed()}|Pace:{GetPace()}";
    }
}