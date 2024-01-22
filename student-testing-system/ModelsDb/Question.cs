using System;
using System.Collections.Generic;

namespace student_testing_system.ModelsDb;

public partial class Question
{
    public int Id { get; set; }

    public string? TextOfQuestion { get; set; }

    public int? ThemeId { get; set; }

    public virtual ICollection<Answer> Answers { get; set; } = new List<Answer>();

    public virtual Theme? Theme { get; set; }
}
