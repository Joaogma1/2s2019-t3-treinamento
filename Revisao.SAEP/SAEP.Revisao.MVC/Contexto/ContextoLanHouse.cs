using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SAEP.Revisao.MVC.Dominios
{
    public partial class ContextoLanHouse : DbContext
    {
        public ContextoLanHouse()
        {
        }

        public ContextoLanHouse(DbContextOptions<ContextoLanHouse> options)
            : base(options)
        {
        }

        public virtual DbSet<Defeito> Defeito { get; set; }
        public virtual DbSet<RegistroDefeito> RegistroDefeito { get; set; }
        public virtual DbSet<TipoEquipamento> TipoEquipamento { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                optionsBuilder.UseSqlServer("Data Source=LAB08DESK3401\\SQLEXPRESS02;Initial Catalog=SAEP;User ID=sa;Password=info@132");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Defeito>(entity =>
            {
                entity.ToTable("DEFEITO");

                entity.HasIndex(e => e.NomeDefeito)
                    .HasName("UQ__DEFEITO__03B03919BEE14ECF")
                    .IsUnique();

                entity.Property(e => e.NomeDefeito)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RegistroDefeito>(entity =>
            {
                entity.ToTable("REGISTRO_DEFEITO");

                entity.Property(e => e.DataRegistro)
                    .HasColumnName("Data_Registro")
                    .HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.IdDefeito).HasColumnName("Id_Defeito");

                entity.Property(e => e.IdTipoEquipamento).HasColumnName("Id_Tipo_equipamento");

                entity.HasOne(d => d.IdDefeitoNavigation)
                    .WithMany(p => p.RegistroDefeito)
                    .HasForeignKey(d => d.IdDefeito)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REGISTRO___Id_De__534D60F1");

                entity.HasOne(d => d.IdTipoEquipamentoNavigation)
                    .WithMany(p => p.RegistroDefeito)
                    .HasForeignKey(d => d.IdTipoEquipamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REGISTRO___Id_Ti__52593CB8");
            });

            modelBuilder.Entity<TipoEquipamento>(entity =>
            {
                entity.ToTable("TIPO_EQUIPAMENTO");

                entity.HasIndex(e => e.Nome)
                    .HasName("UQ__TIPO_EQU__7D8FE3B265E13635")
                    .IsUnique();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("USUARIO");

                entity.HasIndex(e => e.Email)
                    .HasName("UQ__USUARIO__A9D105348BFA4D0D")
                    .IsUnique();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });
        }
    }
}
