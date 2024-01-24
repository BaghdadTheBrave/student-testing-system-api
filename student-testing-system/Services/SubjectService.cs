using student_testing_system.DataDb;
using student_testing_system.ModelsDb;

namespace student_testing_system.Services;

public class SubjectService : ISubjectService
{
    public void AddSubject(Subject subject)
    {
        var context = new StudentTestingSystemDbContext();
        
        context.Subjects.Add(subject);
        context.SaveChanges();
    }
    public List<Subject> GetSubjects()
    {
        using StudentTestingSystemDbContext context = new StudentTestingSystemDbContext();
        var subjects = context.Subjects.ToList();
        return subjects;
    }
}