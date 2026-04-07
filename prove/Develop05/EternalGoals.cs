public class Eternal : Goal
{
    //constructor
    public Eternal(string name, int points,string description, bool iscomplete) : base (name,points,description,iscomplete)
    {
    
    }
public override int RecordEvent()
{
       return GetPoints();
}
 public override string GetGoalType()//lets the program know to use EternalGoal as the goal type
    {
        return $"EternalGoal,{base.GetGoalType()}";
    }    

    }