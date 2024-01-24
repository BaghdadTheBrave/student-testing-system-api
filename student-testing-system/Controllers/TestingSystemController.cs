using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using student_testing_system.Contracts.Question;
using student_testing_system.Contracts.Subject;
using student_testing_system.Contracts.Theme;
using student_testing_system.DataDb;
using student_testing_system.ModelsDb;
using student_testing_system.Models;
using student_testing_system.Services;

namespace student_testing_system.Controllers;



[ApiController]
public class TestingSystemController:ControllerBase
{
    private readonly IQuestionService _questionService;
    private readonly ISubjectService _subjectService;
    private readonly IThemeService _themeService;
public TestingSystemController
    (
        IQuestionService questionService, 
        ISubjectService subjectService, 
        IThemeService themeService
    )
    {
        _questionService = questionService;
        _subjectService = subjectService;
        _themeService = themeService;
    }
    
    [HttpPost("/questions/add")]
    public IActionResult PostNewQuestion( PostQuestionRequest request)
    {
        var question = new ModelsDb.Question()
        {
            TextOfQuestion = request.Question,
            ThemeId = request.ThemeId,
            Id = Guid.NewGuid().GetHashCode()
        };
        var subject = _questionService.AddQuestion(question);
        
        var response = new PostQuestionResponse
            (
                question.Id,
                request.ThemeId,
                subject,
                question.TextOfQuestion,
                request.Answer1,
                request.Answer2,
                request.Answer3
            );
        
        return Ok(response);
    }
    
    [HttpGet("/questions")]
    public IActionResult GetQuestion()
    {
        var question = _questionService.GetQuestion();
        
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
        //TODO: student auth
        var answer = new Answer()
        {
            Id = Guid.NewGuid().GetHashCode(),
            Mark = -1,
            QuestionId = -1,
            StudentId = -1,
            AttemptId = -1
        };
        _questionService.AddAnswer(answer);
        
        var response = new AnswerQuestionResponse(answer.QuestionId ?? -1 ,request.Answer);
        
        return Ok(response);
    }
    
    
    //Subject
    
    
    [HttpPost("/subjects")]
    public IActionResult PostSubject( PostSubjectRequest request)
    {
        var subject = new ModelsDb.Subject()
        {
            Title = request.SubjectName,
            Id = Guid.NewGuid().GetHashCode()
        };
        _subjectService.AddSubject(subject);
        var response = new PostSubjectResponse(subject.Id,subject.Title);
        
        return Ok(response);
    }
    [HttpGet("/subjects")]
    public IActionResult GetSubjects()
    {
        var subjects = _subjectService.GetSubjects();
        
        var titles = subjects.Select(s => s.Title).ToList();
        var ids = subjects.Select(s => s.Id ).ToList();
        var response = new GetSubjectsResponse(titles,ids);
        return Ok(response);
    }
    
    
    //Theme
    [HttpPost("/themes")]
    public IActionResult PostTheme( PostThemeRequest request)
    {
        
        var theme = new ModelsDb.Theme()
        {
            Title = request.ThemeName,
            Id = Guid.NewGuid().GetHashCode(),
            SubjectId = request.SubjectId,
            AmountOfQuestionsPerAttempt = request.questionsAmount,
            NumberOfAttempts = request.attemptsAmount
        };
        
        _themeService.AddTheme(theme);
        
        var response = new PostThemeResponse(
            theme.Id,
            theme.Title,
            theme.SubjectId ?? -1,
            theme.AmountOfQuestionsPerAttempt ?? -1,
            theme.NumberOfAttempts ?? -1
        );
        
        return Ok(response);
    }
    [HttpGet("/themes/{id:int}")]
    public IActionResult GetThemes(int id)
    {
        
        var themes = _themeService.GetThemes(id);
        
        var titles = themes.Select(t => t.Title).ToList();
        var ids = themes.Select(t => t.Id ).ToList();
        
        var response = new GetThemesResponse(titles,ids,id);
        return Ok(response);
    }
}