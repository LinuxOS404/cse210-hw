using System.Drawing;

class Simple : Goal
{


//Constructor
public Simple(string name, int points,string description, bool iscomplete) : base (name,points,description,iscomplete)
    {
    
    }
    //making record the event for Simple Goals
public override int RecordEvent()
{
        if (!GetIsComplete())
        {
         MarkComplete();
         return GetPoints();   
        }
        return 0;
}
//lets the program know to use Simple as the goal type
 public override string GetGoalType()
    {
        return $"SimpleGoal,{base.GetGoalType()}";
    }

    }