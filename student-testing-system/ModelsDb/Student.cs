using System;
using System.Collections.Generic;

namespace student_testing_system.ModelsDb;

public partial class Student
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public virtual ICollection<Answer> Answers { get; set; } = new List<Answer>();

    public virtual ICollection<Attempt> Attempts { get; set; } = new List<Attempt>();

    public virtual UserTable? User { get; set; }
}
