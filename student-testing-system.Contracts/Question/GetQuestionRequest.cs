namespace student_testing_system.Contracts.Question;

public record GetQuestionRequest(
    int UserId,
    int ThemeId,
    int SubjectId
);