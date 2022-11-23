using GENGestion.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GENGestion.Infrastructure.Data.configurations
{
    internal class MedicosConfiguration : IEntityTypeConfiguration<Medicos>
    { 
        public void Configure(EntityTypeBuilder<Medicos> builder)
        {
            builder.ToTable("Medicos");

            builder.HasKey(e => e.Id)
                    .IsClustered(false);

            builder.Property(e => e.Id).HasColumnName("ID");

            builder.Property(e => e.DeApellido)
                            .IsRequired()
                            .HasMaxLength(100);

            builder.Property(e => e.DeCelular)
                            .IsRequired()
                            .HasMaxLength(20);

            builder.Property(e => e.DeDomicilio)
                            .IsRequired()
                            .HasMaxLength(100);

            builder.Property(e => e.DeEmail)
                            .IsRequired()
                            .HasMaxLength(100);

            builder.Property(e => e.DeNombre)
                            .IsRequired()
                            .HasMaxLength(100);

            builder.Property(e => e.DeNumeroAfiliado)
                            .IsRequired()
                            .HasMaxLength(100);

            builder.Property(e => e.DeOcupacion)
                            .IsRequired()
                            .HasMaxLength(100);

            builder.Property(e => e.DeSexo)
                            .IsRequired()
                            .HasMaxLength(1);

            builder.Property(e => e.DeTelefono)
                            .IsRequired()
                            .HasMaxLength(20);

            builder.Property(e => e.DeTipoDocumento)
                            .IsRequired()
                            .HasMaxLength(3)
                            .IsUnicode(false);

            builder.Property(e => e.FeAlta).HasColumnType("datetime");

            builder.Property(e => e.FeNacimiento).HasColumnType("datetime");

            builder.Property(e => e.LocalidadId).HasColumnName("LocalidadID");

            builder.Property(e => e.NuMatricula)
                            .IsRequired()
                            .HasMaxLength(10);

            ///builder.HasOne<>(d => d.Localidad)
                            //.WithMany(p => p.Medicos)
                            //.HasForeignKey(d => d.LocalidadId)
                            //.OnDelete(DeleteBehavior.ClientSetNull)
                            //.HasConstraintName("FK_MedicoLocalidad");
        }
    }
    }
    
