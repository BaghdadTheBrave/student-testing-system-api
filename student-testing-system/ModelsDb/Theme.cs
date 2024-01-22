using System;
using System.Collections.Generic;

namespace student_testing_system.ModelsDb;

public partial class Theme
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public int? SubjectId { get; set; }

    public int? AmountOfQuestionsPerAttempt { get; set; }

    public int? NumberOfAttempts { get; set; }

    public virtual ICollection<Attempt> Attempts { get; set; } = new List<Attempt>();

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

    public virtual Subject? Subject { get; set; }
}
