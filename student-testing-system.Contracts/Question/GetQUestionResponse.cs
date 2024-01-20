namespace student_testing_system.Contracts.Question;

public record GetQuestionResponse(
    Guid QuestionId,
    Guid ThemeId,
    string Question,
    string Answer1,
    string Answer2,
    string Answer3
);
