namespace student_testing_system.Contracts.Question;

public record GetQuestionResponse(
    Guid QuestionId,
    string Question,
    string Qnswer1,
    string Qnswer2,
    string Qnswer3
);
