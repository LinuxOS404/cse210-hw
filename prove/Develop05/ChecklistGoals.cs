

public class CheckList : Goal

{

    private int _bonus;
    private int _completions;

    private int _maxCompletions;
    private int _currentCount;

//constructors
    public CheckList(string name, int points,string description, bool iscomplete,int bonus, int maxCompletions) : base (name,points,description,iscomplete)
    {
    _bonus = bonus;
    _maxCompletions = maxCompletions;
    _currentCount = 0;
    }
public override int RecordEvent()
{
        if(!GetIsComplete())
        {
            int pointSum = 0;
 _completions++;   

 pointSum += GetPoints();

 if (_completions == _maxCompletions)//checks if max completion has been met
        {
          pointSum += _bonus; 

          MarkComplete(); 
        }
        return pointSum;
        }
        else
        {
         return 0;   
        }
    }
 public override string DisplayGoal()
    {
       return ($"{base.DisplayGoal()}{_completions}{_bonus}{_maxCompletions}");
        }
 public override string GetGoalType()//lets the program know to use ChecklistGoal as the goal type
    {
        return $"ChecklistGoal,{base.GetGoalType()}";
    }

    public void SetCurrentCount(int count) //sets the count on the checklist goal
{
    _currentCount = count;
}
}


