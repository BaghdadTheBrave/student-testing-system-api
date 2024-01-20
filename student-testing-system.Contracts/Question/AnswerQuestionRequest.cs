namespace student_testing_system.Contracts.Question;

public record AnswerQuestionRequest
(
    Guid UserId,
    int Answer
);