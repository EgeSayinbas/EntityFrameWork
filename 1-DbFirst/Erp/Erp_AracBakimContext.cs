using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace _1_DbFirst.Erp;

public partial class Erp_AracBakimContext : DbContext
{
    public Erp_AracBakimContext()
    {
    }

    public Erp_AracBakimContext(DbContextOptions<Erp_AracBakimContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblArac> TblAracs { get; set; }

    public virtual DbSet<TblBakim> TblBakims { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=.;Database=Viopack_erp;Trusted_Connection=true;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Turkish_CI_AS");

        modelBuilder.Entity<TblArac>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_arac");

            entity.Property(e => e.Aracid).HasColumnName("aracid");
            entity.Property(e => e.Kodaciklama)
                .HasMaxLength(30)
                .HasDefaultValue("")
                .HasColumnName("kodaciklama");
            entity.Property(e => e.Kullanma)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("kullanma");
            entity.Property(e => e.Olusturanadisoyadi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("olusturanadisoyadi");
            entity.Property(e => e.Olusturmatarihi)
                .HasColumnType("datetime")
                .HasColumnName("olusturmatarihi");
            entity.Property(e => e.Tonaj).HasColumnName("tonaj");
        });

        modelBuilder.Entity<TblBakim>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_bakim");

            entity.Property(e => e.Bakimkod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("bakimkod");
            entity.Property(e => e.Ek1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ek1");
            entity.Property(e => e.Ek2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ek2");
            entity.Property(e => e.Kodaciklama)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kodaciklama");
            entity.Property(e => e.Olusturanadisoyadi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("olusturanadisoyadi");
            entity.Property(e => e.Olusturmatarihi)
                .HasColumnType("datetime")
                .HasColumnName("olusturmatarihi");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
