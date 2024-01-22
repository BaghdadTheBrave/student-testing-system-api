namespace student_testing_system.Contracts.Question;

public record PostQuestionRequest
(
    int ThemeId,
    int SubjectId,
    string Question,
    string Answer1,
    string Answer2,
    string Answer3
);