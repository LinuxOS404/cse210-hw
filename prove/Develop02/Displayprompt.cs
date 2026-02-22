using System;
using System.Collections.Generic;

public class DisplayPrompt
{
    private List<string> prompts = new List<string>
    {
        "Hey there! How's your morning been?",
        "What was the most important part of your day?",
        "What was your favorite thing you ate today?",
        "Did you drink enough water today?",
        "What's something new you did today?",
        "What was you favorite part of today",
        "What made you laugh today?"
    };

    private Random random = new Random();

    public string GetRandomPrompt()
    {
        return prompts[random.Next(prompts.Count)];
    }
}
