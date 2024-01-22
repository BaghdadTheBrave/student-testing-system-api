using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using student_testing_system.ModelsDb;

namespace student_testing_system.DataDb;

public partial class StudentTestingSystemDbContext : DbContext
{
    public StudentTestingSystemDbContext()
    {
    }

    public StudentTestingSystemDbContext(DbContextOptions<StudentTestingSystemDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Answer> Answers { get; set; }

    public virtual DbSet<Attempt> Attempts { get; set; }

    public virtual DbSet<Lecturer> Lecturers { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<Theme> Themes { get; set; }

    public virtual DbSet<UserTable> UserTables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost;Database=student_testing_system_db;Integrated Security=false;User ID=sa;Password=Pass1234;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Answer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__answer__3213E83F8B32E0D0");

            entity.ToTable("answer");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AttemptId).HasColumnName("attemptId");
            entity.Property(e => e.Mark).HasColumnName("mark");
            entity.Property(e => e.QuestionId).HasColumnName("questionId");
            entity.Property(e => e.StudentId).HasColumnName("studentId");

            entity.HasOne(d => d.Attempt).WithMany(p => p.Answers)
                .HasForeignKey(d => d.AttemptId)
                .HasConstraintName("FK__answer__attemptI__4CA06362");

            entity.HasOne(d => d.Question).WithMany(p => p.Answers)
                .HasForeignKey(d => d.QuestionId)
                .HasConstraintName("FK__answer__question__4AB81AF0");

            entity.HasOne(d => d.Student).WithMany(p => p.Answers)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__answer__studentI__4BAC3F29");
        });

        modelBuilder.Entity<Attempt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__attempt__3213E83F123949DA");

            entity.ToTable("attempt");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Mark).HasColumnName("mark");
            entity.Property(e => e.StudentId).HasColumnName("studentId");
            entity.Property(e => e.ThemeId).HasColumnName("themeId");

            entity.HasOne(d => d.Student).WithMany(p => p.Attempts)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__attempt__student__46E78A0C");

            entity.HasOne(d => d.Theme).WithMany(p => p.Attempts)
                .HasForeignKey(d => d.ThemeId)
                .HasConstraintName("FK__attempt__themeId__47DBAE45");
        });

        modelBuilder.Entity<Lecturer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__lecturer__3213E83F6C4DC905");

            entity.ToTable("lecturer");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.User).WithMany(p => p.Lecturers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__lecturer__userId__398D8EEE");
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__question__3213E83F0D1E2879");

            entity.ToTable("question");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.TextOfQuestion)
                .HasMaxLength(510)
                .IsUnicode(false)
                .HasColumnName("text_of_question");
            entity.Property(e => e.ThemeId).HasColumnName("themeId");

            entity.HasOne(d => d.Theme).WithMany(p => p.Questions)
                .HasForeignKey(d => d.ThemeId)
                .HasConstraintName("FK__question__themeI__440B1D61");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__student__3213E83F39CB620B");

            entity.ToTable("student");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.User).WithMany(p => p.Students)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__student__userId__3C69FB99");
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__subject__3213E83F7F811C1A");

            entity.ToTable("subject");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");
        });

        modelBuilder.Entity<Theme>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__theme__3213E83FDD556347");

            entity.ToTable("theme");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AmountOfQuestionsPerAttempt).HasColumnName("amount_of_questions_per_attempt");
            entity.Property(e => e.NumberOfAttempts).HasColumnName("number_of_attempts");
            entity.Property(e => e.SubjectId).HasColumnName("subjectId");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");

            entity.HasOne(d => d.Subject).WithMany(p => p.Themes)
                .HasForeignKey(d => d.SubjectId)
                .HasConstraintName("FK__theme__subjectId__412EB0B6");
        });

        modelBuilder.Entity<UserTable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__user_tab__3213E83F18D97C43");

            entity.ToTable("user_table");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Login)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("login");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("password");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
