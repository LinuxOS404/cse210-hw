using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)


    

    {List<Activity> activities = new List<Activity>();
        activities.Add(new Running(new DateOnly (2027, 10, 3), 50,6.0f));
        activities.Add(new Cycling(new DateOnly (2021, 12, 5), 20,5.0f));
        activities.Add(new Swimming(new DateOnly (2026, 11, 2),30,30));
    
    foreach (var activity in activities)
    {
    Console.WriteLine(activity.GetSummary());
    }
}
}