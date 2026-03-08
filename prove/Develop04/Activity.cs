using System;

// Base class for all activities
public abstract class Activity
{
    protected string _name;
    protected string _description;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public virtual void Start()
    {
        Console.WriteLine($"\nStarting {_name}");
        Console.WriteLine(_description);
    }

    public virtual void End()
    {
        Console.WriteLine("Activity finished.\n");
    }

    public abstract void Run();
}