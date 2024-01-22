using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using student_testing_system.Contracts.Question;
using student_testing_system.Contracts.Subject;
using student_testing_system.Contracts.Theme;
using student_testing_system.DataDb;
using student_testing_system.ModelsDb;
using student_testing_system.Models;

namespace student_testing_system.Controllers;



[ApiController]
public class TestingSystemController:ControllerBase
{
    [HttpPost("/questions/add")]
    public IActionResult PostNewQuestion( PostQuestionRequest request)
    {
        using StudentTestingSystemDbContext context = new StudentTestingSystemDbContext();
        var record = new ModelsDb.Question()
        {
            TextOfQuestion = request.Question,
            ThemeId = request.ThemeId,
            Id = Guid.NewGuid().GetHashCode()
        };
        context.Questions.Add(record);
        var subject = 
            (
                from theme in context.Themes
                where theme.Id == request.ThemeId
                select theme.SubjectId
            ).FirstOrDefault();
        var response = new PostQuestionResponse
            (
                record.Id,
                request.ThemeId,
                subject ?? -1,
                record.TextOfQuestion,
                request.Answer1,
                request.Answer2,
                request.Answer3
            );
        context.SaveChanges();
        //TODO: save answers to txt
        return Ok(response);
    }
    
    [HttpGet("/questions")]
    public IActionResult GetQuestion()
    {
        //TODO: get theme id from txt
        using StudentTestingSystemDbContext context = new StudentTestingSystemDbContext();
        
        var question = context.Questions.OrderBy(q => EF.Functions.Random()).FirstOrDefault(); 
        
        //TODO: get answers from txt
        
        var response = new GetQuestionResponse(
            question.Id,
            question.ThemeId ?? -1,
            question.TextOfQuestion,
            "",
            "",
            ""
        );
        return Ok(response);
    }
    
    [HttpPost("/questions")]
    public IActionResult PostQuestionAnswer( AnswerQuestionRequest request)
    {
        using StudentTestingSystemDbContext context = new StudentTestingSystemDbContext();
        //TODO: grade answer
        //TODO: student auth
        var record = new Answer()
        {
            Id = Guid.NewGuid().GetHashCode(),
            Mark = -1,
            QuestionId = -1,
            StudentId = -1,
            AttemptId = -1
        };
        //context.Answers.Add(record);
        //context.SaveChanges();
        
        var response = new AnswerQuestionResponse(record.QuestionId ?? -1 ,request.Answer);
        
        return Ok(response);
    }
    
    
    //Subject
    
    
    [HttpPost("/subjects")]
    public IActionResult PostSubject( PostSubjectRequest request)
    {
        var context = new StudentTestingSystemDbContext();
        var record = new ModelsDb.Subject()
        {
            Title = request.SubjectName,
            Id = Guid.NewGuid().GetHashCode()
        };
        context.Subjects.Add(record);
        context.SaveChanges();
        var response = new PostSubjectResponse(record.Id,record.Title);
        
        return Ok(response);
    }
    [HttpGet("/subjects")]
    public IActionResult GetSubjects()
    {
        using StudentTestingSystemDbContext context = new StudentTestingSystemDbContext();
        var subjects = context.Subjects.ToList();
        var titles = subjects.Select(s => s.Title).ToList();
        var ids = subjects.Select(s => s.Id ).ToList();
        var response = new GetSubjectsResponse(titles,ids);
        return Ok(response);
    }
    
    
    //Theme
    [HttpPost("/themes")]
    public IActionResult PostTheme( PostThemeRequest request)
    {
        return Ok(request);
    }
    [HttpGet("/themes/{id:int}")]
    public IActionResult GetThemes(int id)
    {
        using StudentTestingSystemDbContext context = new StudentTestingSystemDbContext();
        var themes = context.Themes.Where(t => t.SubjectId == id).ToList();
        var titles = themes.Select(t => t.Title).ToList();
        var ids = themes.Select(t => t.Id ).ToList();
        var response = new GetThemesResponse(titles,ids,id);
        return Ok(response);
    }
}