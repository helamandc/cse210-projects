using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        int quit_int = 5;
        int action_int;



        PromptGenerator prompt = new PromptGenerator();
        DateTime currentDate = DateTime.Today;
        Journal recordEntry = new Journal();

        Console.WriteLine("Welcome to the Journal Program!");

        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.WriteLine("What would you like to do? ");

            string action = Console.ReadLine();
            action_int = int.Parse(action);

            if (action_int == 1)
            {
                string date = currentDate.ToShortDateString();
                Entry journalEntry = new Entry();
                string question = prompt.GetRandomPrompt();
                Console.WriteLine(question);
                string answer = Console.ReadLine();

                journalEntry._date = date;
                journalEntry._promptText = question;
                journalEntry._entrytext = answer;

                recordEntry.AddEntry(journalEntry);
            }
            else if (action_int == 2)
            {
                recordEntry.DisplayAll();
            }
            else if (action_int == 3)
            {
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();
                recordEntry.LoadFromFile(fileName);
            }
            else if (action_int == 4)
            {
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();
                recordEntry.SaveToFile(fileName);
            }
        }
        while (quit_int != action_int);

        Environment.Exit(0);
    }
}