class Cycling : Activity
{

private float _speed;

public Cycling(DateOnly  date, int minutes,float speed) : base(date,minutes)
    {
      this._speed = speed;  
    }

   public override float GetSpeed()
    {
      return _speed;  
    }

    public override float GetPace()
    {
      return 60 / _speed;  
    }

    public override float GetDistance()
    {
      return _speed * GetMinutes() / 60;  
    }

     public override string GetSummary()
    {
      return $"This is cycling - Date:{_date}|Minutes:{GetMinutes()}|Distance:{GetDistance()}|Speed:{GetSpeed()}|Pace:{GetPace()}";
    }











}