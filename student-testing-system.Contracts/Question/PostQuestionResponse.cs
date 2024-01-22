namespace student_testing_system.Contracts.Question;

public record PostQuestionResponse
(
    int QuestionId,
    int ThemeId,
    int SubjectId,
    string Question,
    string Answer1,
    string Answer2,
    string Answer3
);