abstract class Activity
{

protected DateTime date;
protected int miuntes;

public Activity(DateTime date,int minutes)
    {
      this.date = date;
      this.miuntes = minutes;  
    }

public abstract float GetDistance();
 


public abstract float GetSpeed();
 

public abstract float GetPace();

public int GetMinutes()
    {
     return miuntes;   
    }

public virtual string GetSummary()
    {
      return $"Distance:{GetDistance()}\nSpeed:{GetSpeed()}\nPace:{GetPace()}";
    }








}