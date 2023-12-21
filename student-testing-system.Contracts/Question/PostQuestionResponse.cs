namespace student_testing_system.Contracts.Question;

public record PostQuestionResponse
(
    Guid QuestionId,
    string Question,
    string Answer1,
    string Answer2,
    string Answer3
);