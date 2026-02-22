using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void Display()
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }

    public void Save(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
        
        writer.WriteLine("Date,Prompt,Response,Mood");

        foreach (Entry entry in entries)
        {
            writer.WriteLine(entry.ToCsv());
        }

            
            Console.WriteLine("Journal saved successfully!");
            Console.WriteLine("Saved to: " + Path.GetFullPath(filename));
            }
        }
        catch
        {
            Console.WriteLine("Error: Could not save the file.");
        }
    }

    public void Load(string filename)
    {
        try
        {
            entries.Clear();
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                Entry entry = new Entry(parts[1], parts[2], parts[3]);
                entry.Date = parts[0];
                entries.Add(entry);
            }

            
            Console.WriteLine("Journal loaded successfully!");
        }
        catch
        {
            Console.WriteLine("Error: Could not load the file.");
        }
    }
}
