namespace student_testing_system.Contracts.Question;

public record AnswerQuestionResponse
(
    Guid QuestionId,
    int Answer
);