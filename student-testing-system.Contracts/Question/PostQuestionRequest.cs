namespace student_testing_system.Contracts.Question;

public record PostQuestionRequest
(
    string Question,
    string Answer1,
    string Answer2,
    string Answer3
);