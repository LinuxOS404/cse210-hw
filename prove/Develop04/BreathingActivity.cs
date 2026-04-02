using System;

// Simple breathing activity
public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
    }
    
//defining the startbreaths method
    public void StartBreaths()
    {
        Start();
        PromptDuration();
        
        DateTime endTime = getEndTime(GetDuration());
        DateTime startTime = getStartTime();
        
        while(DateTime.Now <= endTime) 
        {
        //prompting user to breathe in and out with animations that shows animation that moves forward as the breaths are longer
        
        Console.WriteLine("...Breathe in...");
        _inhaleTime();
        Console.WriteLine("...Breathe out...");
        _exhaleTime();
        
        startTime = DateTime.Now;
        }
        
        Program program = new Program();
        program.promptActivity();
        
        
        
        End();
       
//defing when to inhale and exhale
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
