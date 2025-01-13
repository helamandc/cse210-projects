using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        int userNumber = 0;
        float sum = 0;
        float average = 0;
        int count = 0;
        int largestNum = 0;

        List<int> numberList = new List<int> ();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            string number = Console.ReadLine();
            userNumber = int.Parse(number);
            numberList.Add(userNumber);
        }
        while(userNumber != 0);

        foreach (int number in numberList)
        {
            sum += number;
        }
        
        count = numberList.Count - 1;

        average = sum / count;

        largestNum = numberList.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNum}");

    }
}