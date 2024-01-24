using student_testing_system.ModelsDb;

namespace student_testing_system.Services;

public interface ISubjectService
{
    void AddSubject(Subject subject);
    List<Subject> GetSubjects();
}