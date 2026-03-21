using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static class scripture;
    public static class reference;
    ublic static class text;

    ublic static class verse;




    static void Main(string[] args)
    {

        ScriptureRef References = new ScriptureRef();

        reference = new Reference("Proverbs", 3, 5, 6);
        scripture = new Scripture(reference,
            "Trust in the Lord with all thine heart and lean not unto thine own understanding in all thy ways acknowledge him and he shall direct thy paths");

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                return;

            scripture.HideRandomWords(1); // Hides 3 words at a time
        }

        

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("All words are hidden. Program ending.");
    }
}
