using System;

string response = "yes";
while (response == "yes")
{
    do
    {
        Console.WriteLine("What is the magic number?");
        int Magicnum = int.Parse(Console.ReadLine()); ;



        int Guessnum = 0;
        int tries = 0;
        do
        {
            Console.WriteLine("What is your guess?");
            Random randomGenerator = new Random();
            Guessnum = randomGenerator.Next(1, 10);
            Console.WriteLine($"The generator number guessed was: {Guessnum}");
            

        tries++;
            if (Guessnum < Magicnum)
            {
                Console.WriteLine("Higher");
            }
            else if (Guessnum > Magicnum)
            {
                Console.WriteLine("Lower");
            }

        } while (Guessnum != Magicnum);

        Console.WriteLine("Correct!");
        Console.WriteLine($"It took your computer {tries} {(tries == 1 ? "try" : "tries to get it right")}");

        Console.Write("Do you want to continue? (yes/no): ");
        response = Console.ReadLine().ToLower();
    } while (response == "yes");
}

