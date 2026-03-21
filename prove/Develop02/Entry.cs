using System;

public class Entry
{
    //Declares variables
    public string Date;
    public string Prompt;
    public string Response;
    public string Mood;

    public Entry(string prompt, string response, string mood)
    {  
        //Takes today's date and fix it into a text version used for a csv
        Date = DateTime.Today.ToShortDateString();
        Prompt = prompt;
        Response = response;
        Mood = mood;
    }
//Asks what user's mood is for their journal entry.
    public void Display()
    {
        Console.WriteLine(Date);
        Console.WriteLine(Prompt);
        Console.WriteLine(Response);
        Console.WriteLine("Mood was: " + Mood);
        Console.WriteLine("--------------------");
    }
//Saves Journal entry to a csv file
    public string ToCsv()
    {
        return Date + "," + Prompt + "," + Response + "," + Mood;
    }
}
