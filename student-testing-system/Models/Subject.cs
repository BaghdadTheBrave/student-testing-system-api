namespace student_testing_system.Models;

public class Subject
{
    public int SubjectId { get;  }
    public string SubjectName { get;  }
    public Subject (string subjectName)
    {
        SubjectId = Guid.NewGuid().GetHashCode();
        SubjectName = subjectName;
    }
}