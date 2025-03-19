using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LoginWorkWithTheHelpOFDBFirst.Models;

public partial class CreateDbforCodeContext : DbContext
{
    public CreateDbforCodeContext()
    {
    }

    public CreateDbforCodeContext(DbContextOptions<CreateDbforCodeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<TblFaculty> TblFaculties { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

 {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FatherName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.StudenClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StudenGender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.StudenName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblFaculty>(entity =>
        {
            entity.ToTable("tblFaculty");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FatherHusbundName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.TeacherName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC276A563C01");

            entity.HasIndex(e => e.Email, "UQ__Users__A9D10534D44B5524").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
