namespace student_testing_system.Contracts.Question;

public record PostQuestionRequest
(
    int ThemeId,
    string Question,
    string Answer1,
    string Answer2,
    string Answer3
);