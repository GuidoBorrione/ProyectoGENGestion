using GENGestion.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GENGestion.Infrastructure.Data.configurations
{
    internal class LocalidadConfiguration : IEntityTypeConfiguration<Localidades>
    {
        public void Configure(EntityTypeBuilder<Localidades> builder)
        {
            builder.ToTable("Localidades");
            builder.HasKey(e => e.Id)
                .IsClustered(false);

            builder.Property(e => e.Id)
                .HasColumnName("ID")
                .ValueGeneratedNever();

            builder.Property(e => e.DeCdPostal).HasMaxLength(9);

            builder.Property(e => e.DeLocalidad).HasMaxLength(100);

            builder.Property(e => e.ProvinciaId).HasColumnName("ProvinciaID");

            builder.HasOne(d => d.Provincia)
                .WithMany(p => p.Localidades)
                .HasForeignKey(d => d.ProvinciaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProvinciasLocalidad");
        }
    }
}

