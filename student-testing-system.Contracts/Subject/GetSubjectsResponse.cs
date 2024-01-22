namespace student_testing_system.Contracts.Subject;

public record GetSubjectsResponse
(
    List<string>Subjects,    
    List<int>SubjectIds
);