class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Cathy Stanton", "Multiplication");
        Console.WriteLine(a1.GetSummary());
        Console.WriteLine();

        MathAssignment m1 = new MathAssignment(
            "Ricardo Rodrigo",
            "Fractions",
            "6.8",
            "4-20"
        );

        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomework());
        Console.WriteLine();

        WritingAssignment w1 = new WritingAssignment(
            "Wendy Waters",
            "TV History",
            "Rescue Heros "
        );

        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInfo());
    }
}
