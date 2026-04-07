using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public abstract class Goal
{
    protected string _name;
  
    protected int _points;

    protected string _description;

    protected bool _iscomplete;

    
//constructors
    public Goal(string name,int points,string description, bool iscomplete)
    {
   _name = name;
    _points = points;
    _iscomplete = iscomplete;
    _description = description;
    }

    public bool GetIsComplete()// checkes whether something is completed 
    {
        return _iscomplete;
    }

    public void MarkComplete() //marks a goal as complete
    {
        _iscomplete = true;
    }
public string GetName()//get the name of the goal
    {
     return _name;   
    }

    public string GetDescription()//gets the description of the goal
    {
     return _description;   
    }

    public int GetPoints()//get the users points
    {
        return _points;
    }
      
    public abstract int RecordEvent();//calls the record event method
    

    public virtual string DisplayGoal()//shows the name description and points of the goal
    {
     if (_iscomplete)
        {
         return ($"[x]{_name}{_description}{_points}");   
        }
        else
        {
        return ($"[]{_name}{_description}{_points}");    
        }
    }
    
public virtual string GetGoalType()//show if it is a simple,eternal, or checklist goal
    {
        return $"{_name},{_description},{_iscomplete},{_points}";
    }

public virtual string GetDetailsString() //shows whether it was completed by using x
{
    
    string status = GetIsComplete() ? "[X]" : "[ ]";
    
    
    return $"{status} {GetName()} ({GetDescription()})";
}
}





