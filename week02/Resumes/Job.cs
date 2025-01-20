public class Job
{
    public string _jobTitle = "";
    public string _company = "";
    public string _tenure = "";
    public Job()
    {
    }

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_tenure}");
    }

}