using System;
using System.Security.Cryptography.X509Certificates;

// Base class for all activities
public abstract class Activity
{
    //declaring variables
    protected string _name;
    protected string _description;

    protected int _duration;

    public Activity()
    {
        
    }
//finding the names and descriptions
 public void ReadName(string name)
    {
         _name = name;
    }

    public void ReadDescription(string description)
    {
            _description = description;
    }
//finiding the duration and converting it to int
public void PromptDuration()
    {
        Console.WriteLine();
        Console.WriteLine("Please enter the length of your session in Seconds: ");
         _duration = Convert.ToInt32(Console.ReadLine());
    }

    public int GetDuration()
    {
    return _duration;
    }
       
   // defining the start method    
    public virtual void Start()
    {
    Console.WriteLine($"\nStarting{_name} Activity");
    Console.WriteLine(_description);
    }
    //defining the end method
        public virtual void End()
    {
        Console.WriteLine($"\nYou have completed the{_name} Activity");
    }

    //creating countdown

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

    //defining the run method
    public void Run()
    {
        Console.Clear();
        PromptDuration();
        StartCount();
    }


//creating my countdown timer
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

    //defining the datetime so program will go fo the amount of duration
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






    