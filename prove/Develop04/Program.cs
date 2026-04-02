using System;
using System.Security.Cryptography.X509Certificates;

public class Program : Activity
{
    
    static void Main(string[] args)
    {
        Program program = new Program();
        program.promptActivity();
    } 
        
         public void promptActivity()
        {
            
        while(true)
        {
        //setting up menu system
        Console.WriteLine("Mindfulness App");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection");
        Console.WriteLine("3. Listing");
        Console.Write("Choose: ");

        string choice = Console.ReadLine();

        Activity activity = null;
//having user choose between activities and prompting system to start methos accroding to activity.
            if (choice == "1")
            {
            BreathingActivity breathingActivity  = new BreathingActivity();
                    
            Console.WriteLine("\nBreathing Activity");
            Console.WriteLine("This activity helps you relax.");
                
            breathingActivity.StartBreaths();
            }
            else if (choice == "2")
            {
            ReflectionActivity reflectionActivity = new ReflectionActivity();
            Console.WriteLine("\nReflection Activity");
            Console.WriteLine("This activity helps you think about good experiences.");

            reflectionActivity.StartReflecting();
            }
            else if (choice == "3")
            {
            ListingActivity listingActivity = new ListingActivity();

                Console.WriteLine("\nListing Activity");
                Console.WriteLine("This activity helps you focus on positive things.");
                listingActivity.StartListing();

            }
            if (choice == "4")
            {
            Console.WriteLine("Thank you for participating: have a nice mindful day!"); 
            break;
            }

            else
            {
            Console.WriteLine("Invalid choice, please try again.");
            return;
            }
        }
    }
    }







