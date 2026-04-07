abstract class Activity
{

protected DateOnly _date;
protected int _minutes;

public Activity(DateOnly  date,int _minutes)
    {
      this._date = date;
      this._minutes = _minutes;  
    }

public abstract float GetDistance();
 


public abstract float GetSpeed();
 

public abstract float GetPace();

public int GetMinutes()
    {
     return _minutes;   
    }

public DateOnly GetDate()
  {
   return _date; 
  }

public virtual string GetSummary()
    {
      return $"Distance:{GetDistance()}\nSpeed:{GetSpeed()}\nPace:{GetPace()}";
    }








}