using System.Threading.Tasks.Dataflow;

public class Resume
{

    public string _myName = "";
    public List<Job> _myJobs = new List<Job>();
    public void DisplayJobLists()
    {
        Console.WriteLine($"Name: {_myName}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _myJobs)
        {
            job.DisplayJobDetails();
        }
    }

}