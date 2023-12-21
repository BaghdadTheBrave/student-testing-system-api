namespace student_testing_system.Contracts.Question;

public record AnswerQuestionRequest
(
    Guid QuestionId,
    Guid UserId,
    int Answer
);