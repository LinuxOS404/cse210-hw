class Running : Activity
{

private float distance;

public Running(DateTime date, int minutes,float distance) : base(date,minutes)
    {
      this.distance = distance;  
    }

   public override float GetSpeed()
    {
      return distance/GetMinutes() * 60;  
    }

    public override float GetPace()
    {
      return GetMinutes()/distance;  
    }

    public override float GetDistance()
    {
      return distance;  
    }











}