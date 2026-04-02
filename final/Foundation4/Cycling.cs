class Cycling : Activity
{

private float speed;

public Cycling(DateTime date, int minutes,float speed) : base(date,minutes)
    {
      this.speed = speed;  
    }

   public override float GetSpeed()
    {
      return speed;  
    }

    public override float GetPace()
    {
      return 60/speed;  
    }

    public override float GetDistance()
    {
      return speed * GetMinutes()/60;  
    }











}