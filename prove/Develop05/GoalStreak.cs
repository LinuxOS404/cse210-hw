using System;
using System.Reflection.Metadata;
using System.IO;

public class GoalStreak : Goal
{
    private int currentStreak = 0;
    private int longestStreak = 0;
    private DateTime lastStudyDate = DateTime.MinValue;

public void DisplayGoalStreak()
    {
        
    }



    public void recordStudy()
    {
        DateTime today = DateTime.Today;

        if (lastStudyDate == today)
        {
            Console.WriteLine("You already have done this today.");
            return;
        }

        if (lastStudyDate == today.AddDays(-1))
        {
            currentStreak++;
        }
        else
        {
            currentStreak = 1;
        }

        lastStudyDate = today;

        if (currentStreak > longestStreak)
        {
            longestStreak = currentStreak;
        }

        Console.WriteLine("Good job! Your streak is now " + currentStreak + " days.");
    }

    public void showStreak()
    {
        Console.WriteLine("Current goal streak: " + currentStreak);
        Console.WriteLine("Longest streak: " + longestStreak);
    }

    public void saveStreak()
    {
        using (StreamWriter writer = new StreamWriter("GoalStreak.txt"))
        {
            writer.WriteLine(currentStreak);
            writer.WriteLine(longestStreak);
            writer.WriteLine(lastStudyDate);
        }
    }

    public void LoadStreak()
    {
        if (File.Exists("GoalStreak.txt"))
        {
            string[] lines = File.ReadAllLines("GoalStreak.txt");

            currentStreak = int.Parse(lines[0]);
            longestStreak = int.Parse(lines[1]);
            lastStudyDate = DateTime.Parse(lines[2]);
        }
    }
}