namespace student_testing_system.Contracts.Question;

public record GetQuestionResponse(
    int QuestionId,
    int ThemeId,
    string Question,
    string Answer1,
    string Answer2,
    string Answer3
);
