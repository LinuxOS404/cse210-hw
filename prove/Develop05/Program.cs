using System;
class Program : Goal
{
static void Main(string[] args)
    {
        Console.WriteLine("Eternal Quest");


while(true)
        {

        Goal goals = null;
        
        Console.WriteLine("\n1.Create new Goal ");
        Console.WriteLine("2. See Existing Goals ");
        Console.WriteLine("3. Save Goals ");
        Console.WriteLine("4. Load Goal");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Show me my score");
        Console.WriteLine("7. Check my Goal Streak");

        Console.WriteLine("7. Quit");


        Console.Write("\nChoose: ");

        string choice = Console.ReadLine();

          if (choice == "1")
            {
                NewGoals newGoals = new NewGoals();
                newGoals.CreateNewGoal();
            }

            else if (choice == "2")

            {
                ExistingGoals existingGoals = new ExistingGoals();
                existingGoals.DisplayExistingGoal();
            }

            else if (choice == "3")
            {
                SaveGoals saveGoals = new SaveGoals();
                saveGoals.InitiateSaving();
            }

            else if (choice == "4")
            {
                LoadGoals loadGoals = new LoadGoals();
                loadGoals.InitiateLoading();
            }

            else if (choice == "5")
            {
                RecordGoalEvent recordGoalEvent = new RecordGoalEvent();
                recordGoalEvent.RecordEvent();
            }
            
            else if (choice == "6")
            {
                GoalsScore goalsScore = new GoalsScore();
                goalsScore.DisplayScore();
            }

            if (choice == "7")
            {
                GoalStreak goalStreak = new GoalStreak();
                goalStreak.DisplayGoalStreak();
            }

            else
            {
            Console.WriteLine("Invalid choice, please try again.");
            return;
            }
        }





}
}
