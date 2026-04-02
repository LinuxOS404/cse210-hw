using System;

// Reflection activity
public class ReflectionActivity : Activity
{
    int countItems = 0;

    private List<string> thinkingPrompts = new List<string>
    {
    "Think of a time where you felt relaxed",
    "Think of a time where you accomplished something difficult",
    "Think of a time where you did a good deed without being rewarded or reconized",
    "Think of a time you saw something beautiful",
    "Think of a time where you are something truly delicious",
       "Think of a time where you got to be with a person youo care about",
    "Think of a time where you watched a good movie",

    };
    
    private Random random = new Random();

    public string GetRandomThinkingPrompt()
    {
        return thinkingPrompts [random.Next(thinkingPrompts.Count)];
    }
    

     private List<string> deeperPrompts = new List<string>
    {
    "Think of a time where you felt relaxed",
    "Think of a time where you accomplished something difficult",
    "Think of a time where you did a good deed without being rewarded or recognized",
    "Think of a time you saw something beautiful",
    "Think of a time where you are something truly delicious",
       "Think of a time where you got to be with a person youo care about",
    "Think of a time where you watched a good movie",

    };

    private Random random1 = new Random();

    public string GetRandomDeeperPrompt()
    {
        return deeperPrompts [random1.Next(deeperPrompts.Count)];
    }
    
    public void StartReflecting()
    {
    Start();
    PromptDuration();

    string thinkingPrompts = GetRandomThinkingPrompt();
    string deeperPrompts = GetRandomDeeperPrompt();

    DateTime startTime = getStartTime();
    DateTime endTime = getEndTime(GetDuration());

     while(DateTime.Now <= endTime)
     {
    startTime = DateTime.Now;
    Console.WriteLine("Use your duration to write as many answers to the following lTHinking prompts:");
    Console.WriteLine($"_____{thinkingPrompts}_____");
    Console.WriteLine("Starting in:");
    Console.ReadLine();
    StartCount();
    Console.WriteLine($"_____{deeperPrompts}_____","Type your answer:");
    
    Console.ReadLine();
    CountdownTimer();
    }


 


        
        
        
      
    }
}

