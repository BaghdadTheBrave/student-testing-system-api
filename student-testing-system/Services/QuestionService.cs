using Microsoft.EntityFrameworkCore;
using student_testing_system.DataDb;
using student_testing_system.ModelsDb;

namespace student_testing_system.Services;

public class QuestionService : IQuestionService
{
    public int AddQuestion(Question question)
    {
        using StudentTestingSystemDbContext context = new StudentTestingSystemDbContext();
        context.Questions.Add(question);
        var subject = 
        (
            from theme in context.Themes
            where theme.Id == question.ThemeId
            select theme.SubjectId
        ).FirstOrDefault();
        context.SaveChanges();
        //TODO: save answers to txt
        return subject ?? -1;
    }
    
    public Question GetQuestion()
    {
        
        //TODO: get theme id from txt
        using StudentTestingSystemDbContext context = new StudentTestingSystemDbContext();
        //TODO: auth dependant question
        var question = context.Questions.OrderBy(q => EF.Functions.Random()).FirstOrDefault(); 
        
        //TODO: get answers from txt
        
        return question;
        
    }
    public void AddAnswer(Answer answer)
    {
        using StudentTestingSystemDbContext context = new StudentTestingSystemDbContext();
        //TODO: grade answer
        //TODO: student auth
        
        //context.Answers.Add(record);
        //context.SaveChanges();
    }
}