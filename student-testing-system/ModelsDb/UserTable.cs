using System;
using System.Collections.Generic;

namespace student_testing_system.ModelsDb;

public partial class UserTable
{
    public int Id { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public virtual ICollection<Lecturer> Lecturers { get; set; } = new List<Lecturer>();

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
