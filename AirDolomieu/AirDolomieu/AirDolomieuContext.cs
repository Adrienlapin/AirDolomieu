using System;
using System.Collections.Generic;
using AirDolomieu.Class;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Configuration;

namespace AirDolomieu
{
    public partial class AirDolomieuContext : DbContext
    {
        public AirDolomieuContext()
        {
        }

        public AirDolomieuContext(DbContextOptions<AirDolomieuContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Avion> Avions { get; set; } = null!;
        public virtual DbSet<Pilote> Pilotes { get; set; } = null!;
        public virtual DbSet<ViewVol> ViewVols { get; set; } = null!;
        public virtual DbSet<Vol> Vols { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.        
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Avion>(entity =>
            {
                entity.HasKey(e => e.Numavion)
                    .HasName("pk_avion");

                entity.ToTable("avion");

                entity.Property(e => e.Numavion)
                    .ValueGeneratedNever()
                    .HasColumnName("numavion");

                entity.Property(e => e.Capacite).HasColumnName("capacite");

                entity.Property(e => e.Localisation)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("localisation")
                    .HasDefaultValueSql("('Paris')");

                entity.Property(e => e.Nomavion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nomavion");
            });

            modelBuilder.Entity<Pilote>(entity =>
            {
                entity.HasKey(e => e.Numpilote)
                    .HasName("pk_pilote");

                entity.ToTable("pilote");

                entity.Property(e => e.Numpilote)
                    .ValueGeneratedNever()
                    .HasColumnName("numpilote");

                entity.Property(e => e.Adresse)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("adresse");

                entity.Property(e => e.Nompilote)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nompilote");
            });

            modelBuilder.Entity<ViewVol>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewVol");

                entity.Property(e => e.Heurearr)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("heurearr");

                entity.Property(e => e.Heuredep)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("heuredep");

                entity.Property(e => e.Nomavion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nomavion");

                entity.Property(e => e.Nompilote)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nompilote");

                entity.Property(e => e.Numvol)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("numvol");

                entity.Property(e => e.Villearr)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("villearr");

                entity.Property(e => e.Villedep)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("villedep");
            });

            modelBuilder.Entity<Vol>(entity =>
            {
                entity.HasKey(e => e.Numvol)
                    .HasName("pk_vol");

                entity.ToTable("vol");

                entity.HasIndex(e => e.Numavion, "VOL_FK1");

                entity.HasIndex(e => e.Numpilote, "VOL_FK2");

                entity.Property(e => e.Numvol)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("numvol");

                entity.Property(e => e.Heurearr)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("heurearr");

                entity.Property(e => e.Heuredep)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("heuredep");

                entity.Property(e => e.Numavion).HasColumnName("numavion");

                entity.Property(e => e.Numpilote).HasColumnName("numpilote");

                entity.Property(e => e.Villearr)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("villearr");

                entity.Property(e => e.Villedep)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("villedep");

                entity.HasOne(d => d.NumavionNavigation)
                    .WithMany(p => p.Vols)
                    .HasForeignKey(d => d.Numavion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk2_vol");

                entity.HasOne(d => d.NumpiloteNavigation)
                    .WithMany(p => p.Vols)
                    .HasForeignKey(d => d.Numpilote)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk1_vol");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
