namespace student_testing_system.Contracts.Theme;

public record GetThemesResponse
(
    List<string>ThemesNames,
    List<int>ThemesIds,
    int SubjectId
);