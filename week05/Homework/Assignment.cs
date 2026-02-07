public class Assignment
{
    // Private member variables
    private string _studentName;
    private string _topic;

    // Constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Getter for student name (needed later)
    public string GetStudentName()
    {
        return _studentName;
    }

    // Method to get summary
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}
