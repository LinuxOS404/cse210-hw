using System;
using System.IO;

class Program
{
    
static void Main(string[] args)
    {

ScriptureList list = new ScriptureList();

        reference = new Reference("Proverbs", 3, 5, 6);
        scripture = new Scripture(reference,
            "1 Now behold, a marvelous work is about to come forth among the children of men.2 Therefore, O ye that embark in the service of God, see that ye serve him with all your heart, might, mind and strength, that ye may stand blameless before God at the last day.3 Therefore, if ye have desires to serve God ye are called to the work;4 For behold the field is white already to harvest; and lo, he that thrusteth in his sickle with his might, the same layeth up in store that he perisheth not, but bringeth salvation to his soul;5 And faith, hope, charity and love, with an eye single to the glory of God, qualify him for the work.6 Remember faith, virtue, knowledge, temperance, patience, brotherly kindness, godliness, charity, humility, diligence.7 Ask, and ye shall receive; knock, and it shall be opened unto you. Amen.");

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                return;

           

        

        Console.Clear();
        
        Console.WriteLine();
        Console.WriteLine("All words are hidden. Program ending.");
    }
}
}
