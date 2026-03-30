using System;
using System.Security.Cryptography.X509Certificates;

// Base class for all activities
public abstract class Activity
{
    protected string _name;
    protected string _description;

    protected int _duration;

    public Activity()
    {
        
    }

    public void ReadName(string name)
    {
         _name = name;
    }

    public void ReadDescription(string description)
    {
            _description = description;
    }

public void PromptDuration()
    {
        Console.WriteLine();
        Console.WriteLine("Please enter the length of your session in Seconds: ");
         _duration = Convert.ToInt32(Console.ReadLine());
    }


    public void FindDuration(int duration)
{
    _duration = duration;
}
    public int GetDuration()
    {
    return _duration;
    }
       
       
    public virtual void Start()
    {
    Console.WriteLine($"\nStarting{_name} Activity");
    Console.WriteLine(_description);
    }
        public virtual void End()
    {
        Console.WriteLine($"\nYou have completed the{_name} Activity");
    }

    public void StartCount()
    {
        Console.Write("...");
        for (int i = 5; i > 0; i--)
        {
        Console.Write(i);
        Thread.Sleep(1000);
        
        Console.Write("\b \b");
        Console.Write("...");
        }
        
        Console.WriteLine("Done");
    }
    public void Run()
    {
        Console.Clear();
        PromptDuration();
        StartCount();
    }



public void CountdownTimer()
    {
        
      

        List<string> timerSymbols = new List<string>();

        {   
       timerSymbols.Add("|");
        timerSymbols.Add("/");
        timerSymbols.Add("-");
        timerSymbols.Add("\\");
        timerSymbols.Add("|");
        timerSymbols.Add("/");
        timerSymbols.Add("-");
        timerSymbols.Add("\\");


    foreach (string s in timerSymbols)
    {
    Console.Write(s);
    Thread.Sleep(1000);
    Console.Write("\b\b");
    
    
    }
    Console.WriteLine("Done");
    }
    }
    public DateTime getEndTime(int duration)
    {
    DateTime endTime = new DateTime();
     endTime = DateTime.Now.AddSeconds(duration);
    

    return endTime;

    }

    public DateTime getStartTime()
    {
        DateTime startTime = new DateTime();
        startTime = DateTime.Now;
        return startTime;
}
}






    