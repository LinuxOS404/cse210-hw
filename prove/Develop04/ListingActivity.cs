using System;

// Listing activity
public class ListingActivity : Activity
{
    public ListingActivity(string name, string description)
        : base(name, description)
    {
    }

    public override void Run()
    {
        Start();

        Console.WriteLine("List things you are grateful for.");

        End();
    }
}