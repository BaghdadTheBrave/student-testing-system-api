using student_testing_system.DataDb;
using student_testing_system.ModelsDb;

namespace student_testing_system.Services;

public class ThemeService : IThemeService
{
    public void AddTheme(Theme theme)
    {
        var context = new StudentTestingSystemDbContext();
        context.Themes.Add(theme);
        context.SaveChanges();
    }
    public List<ModelsDb.Theme> GetThemes(int subjectId)
    {
        using StudentTestingSystemDbContext context = new StudentTestingSystemDbContext();
        var themes = context.Themes.Where(t => t.SubjectId == subjectId).ToList();
        return themes;
    }
}