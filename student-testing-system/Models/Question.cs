namespace student_testing_system.Models;

public class Question
{
    public Guid QuestionId { get;  }
    public Guid ThemeId { get;  }
    public string QuestionText { get;  }
    public string[] answers{ get;  }
    
    
}