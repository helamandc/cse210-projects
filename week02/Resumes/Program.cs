using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._tenure = "2019-2022";

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._tenure = "2022-2023";

        // job1.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume._myName = "Helaman Del Castillo";
        myResume._myJobs.Add(job1);
        myResume._myJobs.Add(job2);
        myResume.DisplayJobLists();

    }
}