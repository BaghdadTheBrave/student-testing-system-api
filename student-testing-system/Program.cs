using student_testing_system.Services;

var builder = WebApplication.CreateBuilder(args);{
    builder.Services.AddControllers();
    builder.Services.AddSwaggerGen();
    builder.Services.AddSingleton<IQuestionService, QuestionService>();
    builder.Services.AddSingleton<ISubjectService, SubjectService>();
    builder.Services.AddSingleton<IThemeService, ThemeService>();
}




var app = builder.Build();{
    app.UseHttpsRedirection();

    //app.UseAuthorization();
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
    
    app.MapControllers();

    app.Run();
}

/*// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
*/



