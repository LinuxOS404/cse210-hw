using System;

// Simple breathing activity
public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
    }
    

    public void StartBreaths()
    {
        Start();
        PromptDuration();
        
        DateTime endTime = getEndTime(GetDuration());
        DateTime startTime = getStartTime();
        
        while(DateTime.Now <= endTime) 
        {
        
        
        Console.WriteLine("...Breathe in...");
        _inhaleTime();
        Console.WriteLine("...Breathe out...");
        _exhaleTime();
        
        startTime = DateTime.Now;
       
        End();
        Program program = new Program();
        program.promptActivity();
        
        
        }
       

  }    
     public void _inhaleTime()
    {
        Console.Write("...");
        for (int i = 4; i > 0; i--)
        {
        Console.Write(i);
        Thread.Sleep(1000);
        
        Console.Write("\b \b");
        Console.Write("...");
        }
        
        Console.WriteLine("Done");
    }

     public void _exhaleTime()
    {
        Console.Write("...");
        for (int i = 6; i > 0; i--)
        {
        Console.Write(i);
        Thread.Sleep(1000);
        
        Console.Write("\b \b");
        Console.Write("...");
        }
        
        Console.WriteLine("Done");
    }

//for i = duration
//   public override void Run(duration)
  
}
