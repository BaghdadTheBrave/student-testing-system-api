using student_testing_system.ModelsDb;

namespace student_testing_system.Services;

public interface IThemeService
{
    void AddTheme(Theme theme);
    List<Theme> GetThemes(int subjectId);
}