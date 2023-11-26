using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Pinacoteca.Models.Entities;

public partial class PinacotecabdContext : DbContext
{
    public PinacotecabdContext()
    {
    }

    public PinacotecabdContext(DbContextOptions<PinacotecabdContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Coleccion> Coleccion { get; set; }

    public virtual DbSet<Cuadro> Cuadro { get; set; }

    public virtual DbSet<Pintor> Pintor { get; set; }

  
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Coleccion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("coleccion");

            entity.Property(e => e.Ciudad).HasMaxLength(80);
            entity.Property(e => e.Direccion).HasColumnType("text");
            entity.Property(e => e.Nombre).HasMaxLength(80);
            entity.Property(e => e.Pais).HasMaxLength(80);
        });

        modelBuilder.Entity<Cuadro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cuadro");

            entity.HasIndex(e => e.IdColeccion, "IdColeccion_idx");

            entity.HasIndex(e => e.IdPintor, "IdPintor_idx");

            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.Dimensiones).HasMaxLength(15);
            entity.Property(e => e.Imagen).HasMaxLength(20);
            entity.Property(e => e.Tecnica).HasMaxLength(50);
            entity.Property(e => e.TituloCuadro).HasMaxLength(100);

            entity.HasOne(d => d.IdColeccionNavigation).WithMany(p => p.Cuadro)
                .HasForeignKey(d => d.IdColeccion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("IdColeccion");

            entity.HasOne(d => d.IdPintorNavigation).WithMany(p => p.Cuadro)
                .HasForeignKey(d => d.IdPintor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("IdPintor");
        });

        modelBuilder.Entity<Pintor>(entity =>
        {
            entity.HasKey(e => e.IdPintor).HasName("PRIMARY");

            entity.ToTable("pintor");

            entity.Property(e => e.Biografia).HasColumnType("text");
            entity.Property(e => e.Ciudad).HasMaxLength(80);
            entity.Property(e => e.FechaFallecimiento).HasMaxLength(15);
            entity.Property(e => e.FechaNacimiento).HasMaxLength(15);
            entity.Property(e => e.Imagen).HasMaxLength(20);
            entity.Property(e => e.Nombre).HasMaxLength(80);
            entity.Property(e => e.Pais).HasMaxLength(80);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
