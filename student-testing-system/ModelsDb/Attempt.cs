using System;
using System.Collections.Generic;

namespace student_testing_system.ModelsDb;

public partial class Attempt
{
    public int Id { get; set; }

    public int? Mark { get; set; }

    public int? StudentId { get; set; }

    public int? ThemeId { get; set; }

    public virtual ICollection<Answer> Answers { get; set; } = new List<Answer>();

    public virtual Student? Student { get; set; }

    public virtual Theme? Theme { get; set; }
}
