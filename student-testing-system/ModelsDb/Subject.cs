using System;
using System.Collections.Generic;

namespace student_testing_system.ModelsDb;

public partial class Subject
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<Theme> Themes { get; set; } = new List<Theme>();
}
