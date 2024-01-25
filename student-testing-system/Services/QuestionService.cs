using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using student_testing_system.DataDb;
using student_testing_system.ModelsDb;

namespace student_testing_system.Services;

public class QuestionService : IQuestionService
{
    public int AddQuestion(Question question, string[]answers)
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
        XDocument doc = XDocument.Load("answers.xml");
        XElement root = doc.Element("answers");
        root.Add(new XElement("question",
            new XElement("id", question.Id), 
            new XElement("answer1", answers[0]), 
            new XElement("answer2", answers[1]), 
            new XElement("answer3", answers[2]))
        );
        doc.Save("answers.xml");
        
        
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