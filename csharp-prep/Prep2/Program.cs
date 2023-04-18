using System;

class Program
{
    static void Main(string[] args)
    {
        //Ask for grade percentage
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int percent = int.Parse(percentage);

        string letterGrade;
        string sign = "";

        //Determine Letter Grade
        if (percent > 90 || percent == 90)
        {
            letterGrade = "A";
        }
        else if (percent > 80 || percent == 80)
        {
            letterGrade = "B";
        }
         else if (percent > 70 || percent == 70)
        {
            letterGrade = "C";
        }
         else if (percent > 60 || percent == 60)
        {
            letterGrade = "D";
        }
         else
        {
            letterGrade = "F";
        }

        //Determine sign (if any)
        if ((percent % 10 > 7 || percent % 10 == 7) && (letterGrade != "F" && letterGrade != "A"))
        {
            sign = "+";
        }
        else if (percent % 10 < 3 && letterGrade != "F")
        {
            sign = "-";
        }
        else
        {}

        //Present Grade to user
        Console.WriteLine($"Your grade: {letterGrade}{sign}");

        //Give congratulations or condolences
        if (letterGrade == "A" || letterGrade == "B" || letterGrade == "C")
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("You didn't pass this class. Try again!");
        }
    }
}