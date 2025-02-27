using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TestNexsus.Data.Models.Entities;

namespace TestNexsus.Data.Models;

public partial class TestContext : DbContext
{
    public TestContext()
    {
    }

    public TestContext(DbContextOptions<TestContext> options)
        : base(options)
    {
    }

    

    public virtual DbSet<TBL_Detail> TBL_Detail { get; set; }

    public virtual DbSet<TBL_Head> TBL_Head { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=NX028;Database=interview;Trusted_Connection=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

       

        modelBuilder.Entity<TBL_Detail>(entity =>
        {
            entity.HasKey(e => new { e.id_Company, e.id_Station, e.id_Head, e.id_Detail });

            entity.Property(e => e.df_CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.df_Name).HasMaxLength(100);

            entity.HasOne(d => d.TBL_Head).WithMany(p => p.TBL_Detail)
                .HasForeignKey(d => new { d.id_Company, d.id_Station, d.id_Head })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBL_Detail_TBL_Head");
        });

        modelBuilder.Entity<TBL_Head>(entity =>
        {
            entity.HasKey(e => new { e.id_Company, e.id_Station, e.id_Head });

            entity.Property(e => e.df_CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.df_Head).HasMaxLength(50);
            entity.Property(e => e.df_Observacion).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
