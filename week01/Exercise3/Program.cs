using System;

class Program
{
    static void Main(string[] args)
    {
        int gNumber = 0;

        //Console.Write("What is the magic number? ");
        //string magicNumber = Console.ReadLine();
        //mNumber = int.Parse(magicNumber);

        Random randomGenerator = new Random();
        int mNumber = randomGenerator.Next(1, 11);

        do
        {
            Console.Write("What is your guess? ");
            string guessNumber = Console.ReadLine();
            gNumber = int.Parse(guessNumber);

            if (gNumber > mNumber)
            {
                Console.Write("Lower\n");
            }
            else if (gNumber < mNumber)
            {
                Console.Write("Higher\n");
            }
            else
            {
                Console.Write("You guessed it!\n");
            }

        }
        while(gNumber != mNumber);




        

    }
}