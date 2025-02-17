using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Helaman Del Castillo", "Fractions");

        Console.WriteLine(assignment.GetSummary());

        MathAssignment math = new MathAssignment("Manleh Castillo", "Division", "6.7", "1-12");

        Console.WriteLine(math.GetHomeworkList());
        WritingAssignment writing = new WritingAssignment("Farra Castillo", "Science", "The mystery of Sierra Madre.");

        Console.WriteLine(writing.GetWritingInformation());


    }
}