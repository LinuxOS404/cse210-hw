using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Mindfulness App");
        Console.WriteLine("1. Breathing");
        Console.WriteLine("2. Reflection");
        Console.WriteLine("3. Listing");
        Console.Write("Choose: ");

        string choice = Console.ReadLine();

        Activity activity = null;

        if (choice == "1")
        {
            activity = new BreathingActivity(
                "Breathing",
                "This activity helps you relax.");
        }
        else if (choice == "2")
        {
            activity = new ReflectionActivity(
                "Reflection",
                "This activity helps you think about good experiences.");
        }
        else if (choice == "3")
        {
            activity = new ListingActivity(
                "Listing",
                "This activity helps you focus on positive things.");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        activity.Run();
    }
}

