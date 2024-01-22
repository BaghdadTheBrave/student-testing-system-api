using System;
using System.Collections.Generic;

namespace student_testing_system.ModelsDb;

public partial class Answer
{
    public int Id { get; set; }

    public int? Mark { get; set; }

    public int? QuestionId { get; set; }

    public int? StudentId { get; set; }

    public int? AttemptId { get; set; }

    public virtual Attempt? Attempt { get; set; }

    public virtual Question? Question { get; set; }

    public virtual Student? Student { get; set; }
}
