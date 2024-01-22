namespace student_testing_system.Contracts.Theme;

public record PostThemeRequest
(
    string ThemeName,
    int SubjectId,
    int questionsAmount,
    int attemptsAmount
);