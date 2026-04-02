class Swimming : Activity
{

private int laps;

public Swimming(DateTime date, int minutes,int laps) : base(date,minutes)
    {
      this.laps = laps;  
    }

   public override float GetSpeed()
    {
      return GetDistance()/GetMinutes() * 60;  
    }

    public override float GetPace()
    {
      return GetMinutes()/GetDistance();  
    }

    public override float GetDistance()
    {
      return laps * 50 / 1000 * 0.62f;  
    }
}











