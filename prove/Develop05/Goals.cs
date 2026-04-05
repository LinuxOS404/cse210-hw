using System.Runtime.CompilerServices;

abstract class Goal
{
    protected string _name;
  
    protected int _points;

    protected bool _iscomplete;


public Goal(string _name,int _points, bool _iscomplete)
    {
    }
    
public void ReadName(string name)
    {
         _name = name;
    }
public void Promptpoints()
    {
    Console.WriteLine();
    Console.WriteLine("Please enter the points the will be reward for completion of this goal: ");
    _points = Convert.ToInt32(Console.ReadLine());
    }

    public int points()
    {
        return _points;
    }
      
    public int RecordEvent(int points)
    {
     Goals = Console.ReadLine("What is your goal:");
    return ;
    }

    public void DisplayGoal()
    
    {
      return ;
    }

public virtual int PointCaluculation()
    {
     return; 
    }

}



