using System;
using System.Collections.Generic;
using Honest.Timesheet.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace Honest.Timesheet.Persistence;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ProjectDbo> Projects { get; set; }

    public virtual DbSet<RecordDbo> Records { get; set; }

    public virtual DbSet<TaskDbo> Tasks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=.\\Data.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProjectDbo>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("PR_Id");
            entity.Property(e => e.Closed)
                .HasColumnType("NUMERIC")
                .HasColumnName("PR_Closed");
            entity.Property(e => e.Name).HasColumnName("PR_Name");
        });

        modelBuilder.Entity<RecordDbo>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("RE_Id");
            entity.Property(e => e.Comment).HasColumnName("RE_Comment");
            entity.Property(e => e.FinishedAt)
                .HasColumnType("DATETIME")
                .HasColumnName("RE_FinishedAt");
            entity.Property(e => e.MinutesSpent).HasColumnName("RE_MinutesSpent");
            entity.Property(e => e.RelTaskId).HasColumnName("RE_RelTaskId");
            entity.Property(e => e.StartedAt)
                .HasColumnType("DATETIME")
                .HasColumnName("RE_StartedAt");

            entity.HasOne(d => d.RelTask).WithMany(p => p.Records)
                .HasForeignKey(d => d.RelTaskId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TaskDbo>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("TA_Id");
            entity.Property(e => e.Closed)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMERIC")
                .HasColumnName("TA_Closed");
            entity.Property(e => e.PlannedTime).HasColumnName("TA_PlannedTime");
            entity.Property(e => e.RelProjectId).HasColumnName("TA_RelProjectId");
            entity.Property(e => e.SourceTaskId).HasColumnName("TA_SourceTaskId");
            entity.Property(e => e.SourceType).HasColumnName("TA_SourceType");
            entity.Property(e => e.Title).HasColumnName("TA_Title");

            entity.HasOne(d => d.RelProject).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.RelProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
