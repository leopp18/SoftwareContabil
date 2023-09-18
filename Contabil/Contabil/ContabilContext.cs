using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Contabil;

public partial class Contexto : DbContext
{
    public Contexto()
    {
    }

    public Contexto(DbContextOptions<Contexto> options)
        : base(options)
    {
    }

    public virtual DbSet<Produto> Produtos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=contabil;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Produto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__produtos__3213E83F810F7461");

            entity.ToTable("produtos");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CofinsCompra)
                .HasColumnType("money")
                .HasColumnName("cofinsCompra");
            entity.Property(e => e.CofinsVenda)
                .HasColumnType("money")
                .HasColumnName("cofinsVenda");
            entity.Property(e => e.Compra)
                .HasColumnType("money")
                .HasColumnName("compra");
            entity.Property(e => e.IcmsCompra)
                .HasColumnType("money")
                .HasColumnName("icmsCompra");
            entity.Property(e => e.IcmsVenda)
                .HasColumnType("money")
                .HasColumnName("icmsVenda");
            entity.Property(e => e.Nome)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.PisCompra)
                .HasColumnType("money")
                .HasColumnName("pisCompra");
            entity.Property(e => e.PisVenda)
                .HasColumnType("money")
                .HasColumnName("pisVenda");
            entity.Property(e => e.Venda)
                .HasColumnType("money")
                .HasColumnName("venda");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
