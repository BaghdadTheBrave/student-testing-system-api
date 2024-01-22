using System;
using System.Collections.Generic;

namespace student_testing_system.ModelsDb;

public partial class Lecturer
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public virtual UserTable? User { get; set; }
}
