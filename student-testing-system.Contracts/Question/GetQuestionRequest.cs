namespace student_testing_system.Contracts.Question;

public record GetQuestionRequest(
    Guid UserId,
    Guid ThemeId,
    Guid SubjectId
);