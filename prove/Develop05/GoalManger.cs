

using System.IO;

    public class GoalManager 
    {
        private List<Goal> goalList = new List<Goal>();
        private int totalPoints;
        private int _level;


        
        public void UpdateLevel()//updates the level determined by the amount of points the user has = the extra stuff
        {
            if (totalPoints >= 5000)
            {
                _level = 5; 
            }
            else if (totalPoints >= 3000)
            {
                _level = 4; 
            }
            else if (totalPoints >= 1500)
            {
                _level = 3; 
            }
            else if (totalPoints >= 500)
            {
                _level = 2; 
            }
            else
            {
                _level = 1; 
            }
        }

        
        public void SaveGoals()//save the goals
        {
            string fileName = AskForFileName();
            
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
               
                outputFile.WriteLine($"Points,{totalPoints}");
                outputFile.WriteLine($"Level,{_level}");

                foreach (Goal goal in goalList)
                {
                    
                    outputFile.WriteLine(goal.GetGoalType());
                }
            }
            Console.WriteLine("Progress saved successfully!");
        }

        
        public void LoadGoals()//loads the goals and the type, name and description.
        {
            string fileName = AskForFileName();
            
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                goalList.Clear();

                foreach (string line in lines)
                {
                    string[] goalParts = line.Split(',');
                    string typeLabel = goalParts[0];

                    if (typeLabel == "Points")
                    {
                        totalPoints = int.Parse(goalParts[1]);
                    }
                    else if (typeLabel == "Level")
                    {
                        _level = int.Parse(goalParts[1]);
                    }
                    else if (typeLabel == "SimpleGoal")
                    {
                        
                        string name = goalParts[1];
                        int points = int.Parse(goalParts[2]);
                        string description = goalParts[3];
                        bool isComplete = bool.Parse(goalParts[4]);
                        
                        goalList.Add(new Simple(name, points, description, isComplete));
                    }
                    else if (typeLabel == "EternalGoal")
                    {
                        goalList.Add(new Eternal(goalParts[1], int.Parse(goalParts[2]), goalParts[3], false));
                    }
                    else if (typeLabel == "ChecklistGoal")

                    if (typeLabel == "Points")
{
    totalPoints = int.Parse(goalParts[1]); // This restores your score
}
{
    
    string name = goalParts[1];
    int points = int.Parse(goalParts[2]);
    string description = goalParts[3];
    bool isComplete = bool.Parse(goalParts[4]);
    int bonus = int.Parse(goalParts[5]);
    int maxCompletions = int.Parse(goalParts[6]);

    
    CheckList checklistGoal = new CheckList(name, points, description, isComplete, bonus, maxCompletions);
    
    
    checklistGoal.SetCurrentCount(int.Parse(goalParts[7]));
    
    goalList.Add(checklistGoal);
}
                }
                Console.WriteLine("Goals loaded. Current level: " + _level);
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }

        private string AskForFileName()
        {
            Console.Write("Enter the filename for the quest file: ");
            return Console.ReadLine();
        }

        public int GetLevel()
{
    return _level;   
}


public int GetTotalPoints()//Gets the whole amount of points a user has
{
    return totalPoints;
}

public void CreateGoal()//creates a goal aka the goal menu one #1 is selected.
{
    
    Console.WriteLine("\nThe types of Goals are:");
    Console.WriteLine("  1. Simple Goal");
    Console.WriteLine("  2. Eternal Goal");
    Console.WriteLine("  3. Checklist Goal");
    Console.Write("Which type of goal would you like to create? ");
    string choice = Console.ReadLine();

    Console.Write("What is the name of your goal? "); string name = Console.ReadLine();
    Console.Write("What is a short description of it? "); string description = Console.ReadLine();
    Console.Write("What is the amount of points associated with this goal? "); int points = int.Parse(Console.ReadLine());

    if (choice == "1")//simple goal
    {
        goalList.Add(new Simple(name, points, description, false));
    }
    else if (choice == "2")//eternal goal
    {
        goalList.Add(new Eternal(name, points, description, false));
    }
    else if (choice == "3")//checklist goal
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        int max = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        int bonus = int.Parse(Console.ReadLine());
        
        goalList.Add(new CheckList(name, points, description, false, bonus, max));
    }
}

public void ListGoalDetails()//Shows what goals there are
{
    Console.WriteLine("The goals are:");

    
    if (goalList.Count == 0)
    {
        Console.WriteLine("No goals created yet.");
    }
    else
    {
        
        for (int i = 0; i < goalList.Count; i++)
        {
            
            
            Console.WriteLine($"{i + 1}. {goalList[i].GetDetailsString()}");
        }
    }
}


public void RecordEvent()//calls RecordEvent method from the individual classes
{
    ListGoalDetails(); 

    Console.Write("Which goal did you accomplish? ");
    int goalIndex = int.Parse(Console.ReadLine()) - 1;

   
    int pointsEarned = goalList[goalIndex].RecordEvent();

    totalPoints += pointsEarned;

    Console.WriteLine($"Congratulations! You earned {pointsEarned} points!");
    Console.WriteLine($"You now have {totalPoints} points.");
    }
    }

