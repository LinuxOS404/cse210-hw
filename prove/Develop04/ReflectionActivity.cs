using System;

// Reflection activity
public class ReflectionActivity : Activity
{
    public ReflectionActivity(string name, string description)
        : base(name, description)
    {
    }

    public override void Run()
    {
        Start();

        Console.WriteLine("Think of a time you helped someone.");
        Console.WriteLine("Why was it meaningful?");

        End();
    }
}