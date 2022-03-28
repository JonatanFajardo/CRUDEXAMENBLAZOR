using Application.Entities.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;

namespace Application.DataAccess.DbContextContainer.Configurations
{
    public partial class tbTipoProductosConfiguration : IEntityTypeConfiguration<tbTipoProductos>
    {
        public void Configure(EntityTypeBuilder<tbTipoProductos> entity)
        {
            entity.HasKey(e => e.tipro_Id);

            entity.Property(e => e.tipro_Codigo)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.tipro_FechaCrea).HasColumnType("datetime");

            entity.Property(e => e.tipro_FechaModifica).HasColumnType("datetime");

            entity.Property(e => e.tipro_Nombre)
                .IsRequired()
                .HasMaxLength(250);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<tbTipoProductos> entity);
    }
}
