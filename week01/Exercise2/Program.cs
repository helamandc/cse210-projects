using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradep = int.Parse(grade);
        string letter = "";

        if (gradep >= 90)
        {
            letter = "A";
        }
        else if (gradep >= 80 && gradep < 90)
        {
            letter = "B";
        }
        else if (gradep >= 70 && gradep < 80)
        {
            letter = "C";
        }
        else if (gradep >= 60 && gradep < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.Write($"Your letter grade is {letter}.");

        if (gradep >= 70)
        {
            Console.Write("Congratulations on passing the course!");
        }
        else
        {
            Console.Write("\nStay motivated so you can pass next time.");
        }

    }
}