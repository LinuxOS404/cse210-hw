using System;

// Simple breathing activity
public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description)
        : base(name, description)
    {
    }

    public override void Run()
    {
        Start();

        Console.WriteLine("Breathe in...");
        Console.WriteLine("Breathe out...");

        End();
    }
}