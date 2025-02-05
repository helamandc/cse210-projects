using System;

class Program
{
    static void Main(string[] args)
    {
        string quit = "quit";
        string action = "";
        // Reference reference1 = new Reference("john", 14, 15);
        // Scripture scripture = new Scripture(reference1, "If ye love me, keep my commandments.");    
        do
        {
            Reference reference2 = new Reference("d&C", 130, 20, 21);
            Scripture scripture = new Scripture(reference2, "There is a law, irrevocably decreed in heaven before the foundations of this world, upon which all blessings are predicated. And when we obtain any blessing from God, it is by obedience to that law upon which it is predicated.\n");

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("Please enter to continue or type 'quit' to finish:");
            action = Console.ReadLine();

            // Display the updated string
            scripture.HideRandomWords(3);
        }
        //Exceeding requirement: Ensuring that the action inputted by the user is always lowercase
        while (quit != action.ToLower());


        Environment.Exit(0);

    }
}