namespace student_testing_system.Models;

public class Theme
{
    public int ThemeId { get;  }
    public int SubjectId { get;  }
    public string ThemeName { get; }
    
    public Theme (int subjectId, string themeName)
    {
        ThemeId = Guid.NewGuid().GetHashCode();
        SubjectId = subjectId;
        ThemeName = themeName;
    }
    
}