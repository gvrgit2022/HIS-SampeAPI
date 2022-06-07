using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SampleAPI.Infrastructure.Models.Test
{
    public partial class testContext : DbContext
    {
        public testContext()
        {
        }

        public testContext(DbContextOptions<testContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TutorialsTbl> TutorialsTbls { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("server=localhost;database=test;uid=root;pwd=Sql@2021;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TutorialsTbl>(entity =>
            {
                entity.HasKey(e => e.TutorialId)
                    .HasName("PRIMARY");

                entity.ToTable("tutorials_tbl");

                entity.Property(e => e.TutorialId).HasColumnName("tutorial_id");

                entity.Property(e => e.SubmissionDate)
                    .HasColumnType("date")
                    .HasColumnName("submission_date");

                entity.Property(e => e.TutorialAuthor)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("tutorial_author");

                entity.Property(e => e.TutorialTitle)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("tutorial_title");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
