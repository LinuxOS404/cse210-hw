public abstract class Goal
{
   protected internal string _name;
  protected internal string _description;
    protected internal int _points;

public void PromptPoints(){
    
Console.WriteLine();
Console.WriteLine("Please enter the points you wiill earn for completing the goal: ");
_points = Convert.ToInt32(Console.ReadLine());
}

}