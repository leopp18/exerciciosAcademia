using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Desafio02Entity;

public partial class Contexto : DbContext
{
    public Contexto()
    {
    }

    public Contexto(DbContextOptions<Contexto> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Fornecedor> Fornecedores { get; set; }

    public virtual DbSet<Nota> Notas { get; set; }

    public virtual DbSet<Produto> Produtos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost;initial Catalog=desafio02;User ID=usuario;password=senha;language=Portuguese;Trusted_Connection=True;TrustServerCertificate=True;")
        .UseLazyLoadingProxies();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__clientes__3213E83F4ACCE367");

            entity.ToTable("clientes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cpf)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("cpf");
            entity.Property(e => e.DataNasc)
                .HasColumnType("date")
                .HasColumnName("dataNasc");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Endereco)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("endereco");
            entity.Property(e => e.Nome)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Fornecedor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__forneced__3213E83F286E241B");

            entity.ToTable("fornecedores");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("cnpj");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Endereco)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("endereco");
            entity.Property(e => e.Nome)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Nota>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__notas__3213E83F67E02B31");

            entity.ToTable("notas");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DataEmissao)
                .HasColumnType("datetime")
                .HasColumnName("dataEmissao");
            entity.Property(e => e.Descricao)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.FkCliente).HasColumnName("fk_cliente");
            entity.Property(e => e.FkProduto).HasColumnName("fk_produto");
            entity.Property(e => e.Quantidade).HasColumnName("quantidade");
            entity.Property(e => e.ValorUnitario)
                .HasColumnType("money")
                .HasColumnName("valorUnitario");

            entity.HasOne(d => d.FkClienteNavigation).WithMany(p => p.Nota)
                .HasForeignKey(d => d.FkCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__notas__fk_client__3D5E1FD2");

            entity.HasOne(d => d.FkProdutoNavigation).WithMany(p => p.Nota)
                .HasForeignKey(d => d.FkProduto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__notas__fk_produt__3E52440B");
        });

        modelBuilder.Entity<Produto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__produtos__3213E83FBD83C6BC");

            entity.ToTable("produtos");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FkFornecedor).HasColumnName("fk_fornecedor");
            entity.Property(e => e.Nome)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Valor)
                .HasColumnType("money")
                .HasColumnName("valor");

            entity.HasOne(d => d.FkFornecedorNavigation).WithMany(p => p.Produtos)
                .HasForeignKey(d => d.FkFornecedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__produtos__fk_for__2F10007B");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
