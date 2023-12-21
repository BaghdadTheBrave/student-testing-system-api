namespace student_testing_system.Contracts.Theme;

public record PostThemeResponse
(
    Guid ThemeId,
    string ThemeName,
    Guid SubjectId
);