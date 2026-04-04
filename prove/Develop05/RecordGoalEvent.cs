public class RecordGoalEvent : Goal
{

public void RecordEvent()
{
        
}  

    public void Save(string filename)
    {
        try
        {
            //opens a file and writes text to the file
         using (StreamWriter writer = new StreamWriter(filename))
        {
        
        writer.WriteLine("Date,Prompt,Response,Mood");

        foreach (Entry JournalEntry in entries)
        {
            //Write journal Entry into the csv file
            writer.WriteLine(JournalEntry.ToCsv());
        }

            //Check if the save was successfull or not
            Console.WriteLine("Journal saved successfully!");
            Console.WriteLine("Saved to: " + Path.GetFullPath(filename));
            }
        }
        catch
        {
            Console.WriteLine("Error: Could not save the file.");
        }
    }
//have journal.csv make sure it get pulled up successfully and pull up error if file is not able to be loaded
    public void Load(string filename)
    {
        try
        {
            entries.Clear();
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                Entry JournalEntry = new Entry(parts[1], parts[2], parts[3]);
                JournalEntry.Date = parts[0];
                entries.Add(JournalEntry);
            }

            
            Console.WriteLine("Journal loaded successfully!");
        }
        catch
        {
            Console.WriteLine("Error: Could not load the file.");
        }
    }
}


