using System;
using System.Runtime.InteropServices.Marshalling;

Journal journal = new Journal();
DisplayPrompt prompt = new DisplayPrompt();
string answer;
//List journal options
do
    {
        Console.WriteLine("\n1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Quit");
        Console.WriteLine("");
        Console.Write("What would you like to do today?: ");

        string choice = Console.ReadLine();
  //Assigns options to numbers so they can be chosen by the journal user
        if (choice == "1")
        {
            string Prompt = prompt.GetRandomPrompt();
            Console.WriteLine(Prompt);

            Console.Write("Response: ");
            string response = Console.ReadLine();

            Console.Write("Mood: ");
            string mood = Console.ReadLine();

            journal.AddEntry(new Entry(Prompt, response, mood));
        }
        else if (choice == "2")
        {
            journal.Display();
        }
        else if (choice == "3")
        {
            Console.Write("Filename: ");
            journal.Save(Console.ReadLine());
        }
        else if (choice == "4")
        {
            Console.Write("Filename: ");
            journal.Load(Console.ReadLine());
        }
        else if (choice == "5")
        {
            break;
        }
//asks if user would like to continue
        Console.Write("Do you want to continue? (y/n): ");
        answer = Console.ReadLine().ToLower();

    }
 while (answer == "y");


