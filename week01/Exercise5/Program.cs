using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string uName = PromptUserName();
        int uNumber = PromptUserNumber();
        int sqNumber = SquareNumber(uNumber);

        DisplayResult(uName,sqNumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        string userName = "";
        Console.Write("Please enter your name: ");
        userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        int userNumber = 0;
        Console.Write("Please enter your favorite number: ");
        string number = Console.ReadLine();
        userNumber = int.Parse(number);
        return userNumber;
    }

    static int SquareNumber(int num)
    {
        int numSquare = 0;
        numSquare = num * num;
        return numSquare;
    }

    
    static void DisplayResult(string nameUser,int numberSquare)
    {
        Console.WriteLine($"{nameUser}, the square of your number is {numberSquare}");
    }
}