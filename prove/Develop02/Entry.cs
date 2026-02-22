using System;

public class Entry
{
    public string Date;
    public string Prompt;
    public string Response;
    public string Mood;

    public Entry(string prompt, string response, string mood)
    {
        Date = DateTime.Now.ToShortDateString();
        Prompt = prompt;
        Response = response;
        Mood = mood;
    }

    public void Display()
    {
        Console.WriteLine(Date);
        Console.WriteLine(Prompt);
        Console.WriteLine(Response);
        Console.WriteLine("Mood was: " + Mood);
        Console.WriteLine("--------------------");
    }

    public string ToCsv()
    {
        return Date + "," + Prompt + "," + Response + "," + Mood;
    }
}
