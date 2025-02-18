using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        Console.WriteLine("Menu Options:\n1. Start Breathing Activity\n2. Start Reflecting Activity\n3. Start Listing Activity\n4. Quit\nSelect a choice from the menu: ");

        choice = Console.ReadLine();

        if (choice == "1")//Breathing Activity
        {
            BreathingActivity breathing = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n", 15) { };

            breathing.DisplayStartingMessage();
            Console.WriteLine("Inhale and exhale for 15 seconds. Would you like to proceed? Yes or No\n");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "yes")
            {
                breathing.run();
                for (int i = 15; i > 0; i--)
                {
                    Console.Write(i + "...");
                    Thread.Sleep(1000);
                }
            }
            else if (answer.ToLower() == "no")
            {
                Environment.Exit(0);
            }

            breathing.DisplayEndingMessage();

        }
        else if (choice == "2") //Reflecting Activity
        {
            ReflectingActivity reflecting = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n", 15) { };

            reflecting._prompts.Add("---Think of a time when you did something really difficult.---");
            reflecting._prompts.Add("---Think of a time when you helped someone in need.---");

            reflecting._questions.Add(">How did you feel after doing it?");
            reflecting._questions.Add(">What is one thing you have learned from that experience?");

            reflecting.DisplayStartingMessage();
            reflecting.run();
            Console.Write("Consider the following prompt:\n");
            reflecting.DisplayPrompt();
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();
            reflecting.DisplayQuestions();
            for (int i = 15; i > 0; i--)
            {
                Console.Write(i + "...");
                Thread.Sleep(1000);
            }
            reflecting.DisplayEndingMessage();
        }
        else if (choice == "3") //Listing Activity
        {
            int count = 15;
            ListingActivity listing = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", count) { };

            listing._count = count;
            listing._prompt.Add("---When have you felt the Holy Ghost this month?---");
            listing._prompt.Add("---What are you thankful for to Heavenly Father?---");

            listing.DisplayStartingMessage();
            listing.run();
            Console.Write("List as many as you can to the following prompt:\n");
            listing.GetRandomPrompt();
            Console.WriteLine($"You have {listing._count} seconds to list them:");
            do
            {
                string itemList = Console.ReadLine();
                listing._items.Add(itemList);
            } while (listing._items.Count() != 4);

            Console.WriteLine($"You listed {listing._items.Count()} items!");
            listing.DisplayEndingMessage();
        }
        else
        {
            Environment.Exit(0);
        }

    }
}