using System;
using System.Reflection.Metadata;

// Listing activity
public class ListingActivity : Activity
{
    int countItems = 0;   
  
    private List<string> listItems = new List<string>
    {
        "Hey there! How's your morning been?",
        "What was the most important part of your day?",
        "What was your favorite thing you ate today?",
        "Did you drink enough water today?",
        "What's something new you did today?",
        "What was you favorite part of today",
        "What made you laugh today?",
        "What scripture stuck out to you in you study today?",
        "What did I do to help someone today"

    };

    //pull up random prompts from prompts list for writing
    private Random random = new Random();

    public string GetRandomPrompt()
    {
        return listItems[random.Next(listItems.Count)];
    }
//defning the startlisting method
     public void StartListing()
    {
        Start();
        PromptDuration();

    string listItems = GetRandomPrompt();
    Console.WriteLine();
    Console.WriteLine("Use your duration to write as many answers to the following listitem:");
    Console.WriteLine($"_____{listItems}_____");
    Console.WriteLine("Starting in:");
    StartCount();
    
    Console.WriteLine();

    DateTime startTime = getStartTime();
    DateTime endTime = getEndTime(GetDuration());


    while(DateTime.Now <= endTime) 
    {
        startTime = DateTime.Now;
        Console.Write( ">");
        Console.ReadLine();
        countItems++;


    }
//having the program count how many responses were given
    Console.Write($"You've written {countItems} responses ");

    End();

    Program program = new Program();
    program.promptActivity();
        
    }
    
}
