using System;

Journal journal = new Journal();
DisplayPrompt prompt = new DisplayPrompt();
string answer;

do
    {
        Console.WriteLine("\n1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Quit");
        Console.Write("Choice: ");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            string p = prompt.GetRandomPrompt();
            Console.WriteLine(p);

            Console.Write("Response: ");
            string response = Console.ReadLine();

            Console.Write("Mood: ");
            string mood = Console.ReadLine();

            journal.AddEntry(new Entry(p, response, mood));
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

        Console.Write("Do you want to continue? (y/n): ");
        answer = Console.ReadLine().ToLower();

    }
 while (answer == "y");


