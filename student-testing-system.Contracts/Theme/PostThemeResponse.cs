namespace student_testing_system.Contracts.Theme;

public record PostThemeResponse
(
    int ThemeId,
    string ThemeName,
    int SubjectId,
    int questionsAmount,
    int attemptsAmount
);