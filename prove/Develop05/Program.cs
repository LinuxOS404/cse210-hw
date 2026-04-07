using System;
class Program 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Eternal Quest");

        GoalManager manager = new GoalManager();
        
        Console.WriteLine("Welcome to the Eternal Quest Program!");

        bool running = true;
        while(running)
        {
            //Show the points and level of the user = the extra thing of this program to get full points
            manager.UpdateLevel();
            Console.WriteLine($"\nYou have {manager.GetTotalPoints()} points.");
            Console.WriteLine($"Current Level: {manager.GetLevel()}");

//show the menu to the user
        Console.WriteLine("1.Create new Goal ");
        Console.WriteLine("2. See Existing Goals ");
        Console.WriteLine("3. Save Goals ");
        Console.WriteLine("4. Load Goal");
        Console.WriteLine("5. Record Event");

        Console.WriteLine("7. Quit");


        Console.Write("\nChoose: ");

        string choice = Console.ReadLine();

        //Use the methods attched to the option
        if (choice == "1")//creates a goal and shows user the Goal menu.
        {
            manager.CreateGoal(); 
        }
        else if (choice == "2") //show the user the goals they already have.
        {
            manager.ListGoalDetails(); 
        }
        else if (choice == "3")//save the user's goals
        {
            manager.SaveGoals(); // 
        }
        else if (choice == "4")//Load the user's goals
        {
            manager.LoadGoals(); 
        }
        else if (choice == "5")//Record an event base on which goal was achieved.
        {
            manager.RecordEvent();
        }
        
        else if (choice == "6")//stop program so user can quit
        {
            running = false; 
        }
    } 
}
} 


        


