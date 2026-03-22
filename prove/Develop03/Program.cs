using System;
using System.IO;

class Program
{
    
static void Main(string[] args)
    {
string content = File.ReadAllText("ScriptureMastery.txt");
string[] verseBlock = content.Split(new[] { "\n\n","\r\n\r\n" }, StringSplitOptions.RemoveEmptyEntries);

Random random = new Random();

string playAgain = "y";

do
{
            
        
int randomIndex = random.Next(0, verseBlock.Length);
string chosenBlock = verseBlock[randomIndex];

string[] parts = chosenBlock.Split('|');
    
    if (parts.Length ==2)
    {
            
        


     Verse verse = Verse.Parse(parts[0].Trim());
    Scripture scripture= new Scripture(verse, parts[1].Trim());

        while (!scripture.AllBlank())
        {
            Console.Clear();
            Console.WriteLine(scripture.ShowVerse());
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                return;
        scripture.HideRandom();
        }    
        Console.Clear();
        
        Console.WriteLine();
        Console.WriteLine("Congrats! You have memorized the Scripture, Good Job!."); 
        Console.WriteLine("Would you like to Memorize another verse? (y/n)");
    }

        playAgain = Console.ReadLine().ToLower();

    } while (playAgain == "yes" || playAgain == "y");

    Console.WriteLine("Great job today! Goodbye.");

}
}



