using student_testing_system.ModelsDb;

namespace student_testing_system.Services;

public interface IQuestionService
{
    int AddQuestion(Question question, string[]answers);
    Question GetQuestion();
    void AddAnswer(Answer answer);
}