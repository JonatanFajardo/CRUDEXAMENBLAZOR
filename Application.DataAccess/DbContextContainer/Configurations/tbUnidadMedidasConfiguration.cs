using Application.Entities.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;

namespace Application.DataAccess.DbContextContainer.Configurations
{
    public partial class tbUnidadMedidasConfiguration : IEntityTypeConfiguration<tbUnidadMedidas>
    {
        public void Configure(EntityTypeBuilder<tbUnidadMedidas> entity)
        {
            entity.HasKey(e => e.unime_Id);

            entity.Property(e => e.unime_Codigo)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.unime_FechaCrea).HasColumnType("datetime");

            entity.Property(e => e.unime_FechaModifica).HasColumnType("datetime");

            entity.Property(e => e.unime_Nombre)
                .IsRequired()
                .HasMaxLength(250);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<tbUnidadMedidas> entity);
    }
}
