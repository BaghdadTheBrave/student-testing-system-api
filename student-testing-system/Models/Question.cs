namespace student_testing_system.Models;

public class Question
{
    public int QuestionId { get;  }
    public int ThemeId { get;  }
    public string QuestionText { get;  }
    public string[] answers{ get;  }
    
    public Question (int themeId, string questionText, string[] answers)
    {
        QuestionId = Guid.NewGuid().GetHashCode();
        ThemeId = themeId;
        QuestionText = questionText;
        this.answers = answers;
    }
    
}