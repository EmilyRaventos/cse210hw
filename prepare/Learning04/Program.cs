using System;

class Program
{
    static void Main(string[] args)
    {
        // Test Step 3
        Assignment a1 = new Assignment("Emily Raventos", "Inheritance");
        Console.WriteLine(a1.GetSummary());

        // Test Step 4
        MathAssignment ma1 = new MathAssignment("Joshua Raventos", "Fractions", "5.2", "1-10");
        Console.WriteLine(ma1.GetSummary());
        Console.WriteLine(ma1.GetHomeworkList());

        // Test Step 5
        WritingAssignment wa1 = new WritingAssignment("Kylee Raventos", "Creative Writing", "The Hourglass Chronicles");
        Console.WriteLine(wa1.GetSummary());
        Console.WriteLine(wa1.GetWritingInformation());
    }
}