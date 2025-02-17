public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        string topic = GetTopic();
        string info = studentName + " - " + _title + "\n" + topic;
        return info;
    }
}