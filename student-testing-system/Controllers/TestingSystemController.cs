using Microsoft.AspNetCore.Mvc;
using student_testing_system.Contracts.Question;
using student_testing_system.Contracts.Subject;
using student_testing_system.Contracts.Theme;

namespace student_testing_system.Controllers;
[ApiController]
public class TestingSystemController:ControllerBase
{
    
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
        return Ok(request);
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