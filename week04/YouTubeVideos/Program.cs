using System;

class Program
{
    //Author: Helaman Del Castillo
    //Youtube Video Program
    static void Main(string[] args)
    {
        string videoChoice = "";
        string exit = "0";

        Console.WriteLine("Here the videos: \n");

        Video video1 = new Video("1. The Peace and Hope of Easter", "Pres. Russell M. Nelson", 300);
        Video video2 = new Video("2.Why do we need a church?", "Pres. Dallin H. Oaks", 300);
        Video video3 = new Video("3. It's not too late to repent", "Elder D. Todd Christofferson", 300);

        video1.DisplayVideo();
        video2.DisplayVideo();
        video3.DisplayVideo();

        Console.WriteLine("\nWhich video would you like to add your comments on? Select the number or 0 to skip: ");
        videoChoice = Console.ReadLine();

        do
        {
            if (videoChoice == "1")
            {
                Comment comment = new Comment();
                Console.WriteLine("Write your comments below or type 'quit': ");
                comment._comment = Console.ReadLine();
                comment._name = Environment.UserName;
                video1._comments1.Add(comment);
                if (comment._comment == "quit")
                {
                    video1.DisplayVideo();
                    video1.DisplayVideoLists1();
                    Console.WriteLine($"Total # of comments: {video1.CountComments1()}");
                    Environment.Exit(0);
                }
            }
            else if (videoChoice == "2")
            {
                Comment comment = new Comment();
                Console.WriteLine("Write your comments below or type 'quit': ");
                comment._comment = Console.ReadLine();
                comment._name = Environment.UserName;
                video2._comments2.Add(comment);
                if (comment._comment == "quit")
                {
                    video2.DisplayVideo();
                    video2.DisplayVideoLists2();
                    Console.WriteLine($"Total # of comments: {video2.CountComments2()}");
                    Environment.Exit(0);
                }
            }
            else if (videoChoice == "3")
            {
                Comment comment = new Comment();
                Console.WriteLine("Write your comments below or type 'quit': ");
                comment._comment = Console.ReadLine();
                comment._name = Environment.UserName;
                video3._comments3.Add(comment);
                if (comment._comment == "quit")
                {
                    video3.DisplayVideo();
                    video3.DisplayVideoLists3();
                    Console.WriteLine($"Total # of comments: {video3.CountComments3()}");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Kindly select properly.");
            }
        }
        while (exit != videoChoice);

        Environment.Exit(0);


    }
}