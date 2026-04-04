public class SaveGoals : Goal
{

public void InitiateSaving(string filename)

 {
    using (StreamWriter writer = new StreamWriter("goals.txt"))
    {
      writer.WriteLine($"{_name},{_description},{_points}");
    }
  }
}