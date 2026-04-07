class Swimming : Activity
{

private int _laps;

public Swimming(DateOnly date, int minutes,int laps) : base(date,minutes)
    {
      this._laps = laps;  
    }

   public override float GetSpeed()
    {
      return GetDistance() / GetMinutes() * 60;  
    }

    public override float GetPace()
    {
      return GetMinutes()/GetDistance();  
    }

    public override float GetDistance()
    {
      return _laps * 50 / 1000 * 0.62f;  
    }
     public override string GetSummary()
    {
      return $"This is swimming - Date:{_date}|Minutes:{GetMinutes()}|Distance:{GetDistance()}|Speed:{GetSpeed()}|Pace:{GetPace()}";
    }
}











