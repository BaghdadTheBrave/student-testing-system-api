using Microsoft.AspNetCore.Mvc;
using student_testing_system.Contracts.Question;
using student_testing_system.Contracts.Subject;
using student_testing_system.Contracts.Theme;
using student_testing_system.DbData;
using student_testing_system.DbModels;

namespace student_testing_system.Controllers;



[ApiController]
public class TestingSystemController:ControllerBase
{
    public static Guid ToGuid(int value)
    {
        byte[] bytes = new byte[16];
        BitConverter.GetBytes(value).CopyTo(bytes, 0);
        return new Guid(bytes);
    }
    //Question
    
    
    [HttpPost("/questions/add")]
    public IActionResult PostNewQuestion( PostQuestionRequest request)
    {
        return Ok(request);
    }
    [HttpGet("/questions")]
    public IActionResult GetQuestion( GetQuestionRequest request)
    {
        return Ok(request);
    }
    [HttpPost("/questions")]
    public IActionResult PostQuestionAnswer( AnswerQuestionRequest request)
    {
        return Ok(request);
    }
    
    
    //Subject
    
    
    [HttpPost("/subjects")]
    public IActionResult PostSubject( PostSubjectRequest request)
    {
        return Ok(request);
    }
    [HttpGet("/subjects")]
    public IActionResult GetSubjects( GetSubjectsResponse request)
    {
        using StudentTestingSystemDbContext context = new StudentTestingSystemDbContext();
        var subjects = context.Subjects.ToList();
        var titles = subjects.Select(s => s.Title).ToList();
        var ids = subjects.Select(s => s.Id ).ToList();
        return Ok(new GetSubjectsResponse(titles,ids));
    }
    
    
    //Theme
    [HttpPost("/themes")]
    public IActionResult PostTheme( PostThemeRequest request)
    {
        return Ok(request);
    }
    [HttpGet("/themes")]
    public IActionResult GetThemes( GetThemesRequest request)
    {
        return Ok(request);
    }
}