using System;
using System.Reflection.Metadata.Ecma335;

public class Program : Event
{

public Program(string title, string description, DateTime date, TimeSpan time, Address address) : base(title, description, date, time, address)
    {
    }
    static void Main(string[] args)
    {
        Address addr1 = new Address("123 Main St", "Washington", "DC", "62324");

        Address addr2 = new Address("57 Kawaii way", "Tokyo", "Japan", "14235");

        Address addr3 = new Address("890 Barkington Rd", "Providence", "RH", "325234");
 
        Lecture lecture = new Lecture("Moooo", "Cows and loving them", new DateTime(2025, 3, 20), new TimeSpan(16, 0, 0), addr1, "Dr. Moobert", 150);

        Reception reception = new Reception("Earth day", "Celebrate our planet", new DateTime(2025, 4, 5), new TimeSpan(15, 30, 0), addr2, "earth@events.com");

        OutdoorGathering outdoor = new OutdoorGathering("Sleep under the stars", "Campout under the sky", new DateTime(2025, 6, 18), new TimeSpan(12, 3, 4), addr3, "Foggy, 68°F");
        
        Console.WriteLine(lecture.GetMessages());
        Console.WriteLine();
        Console.WriteLine(reception.GetMessages());
        Console.WriteLine();
        Console.WriteLine(outdoor.GetMessages());
        Console.WriteLine();
    }
}

  


