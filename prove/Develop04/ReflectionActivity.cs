using System;

// Reflection activity
public class ReflectionActivity : Activity
{
    int countItems = 0;

    //get first prompts for user to respond to

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
    
//get second deeper resonse
     private List<string> deeperPrompts = new List<string>
    {
    "How did you feel, and why",
    "Would you plan on doing something like that again",
    "How could it have been a better experience",
    "How have you grown since then",
    "What sense were used",
    "What do you remember the most about that experience",
    "Have you had experineces like that since then?",

    };
//having it pull up random prompts for the user.
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
//sending first promprs and deeper prompts during the whole duration.
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

