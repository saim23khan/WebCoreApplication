using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebCrudApplicationScaff.Models;

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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{}

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
                //.HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.TeacherName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
