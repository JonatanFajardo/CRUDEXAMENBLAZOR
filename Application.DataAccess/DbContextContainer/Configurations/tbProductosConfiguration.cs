using Application.Entities.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;

namespace Application.DataAccess.DbContextContainer.Configurations
{
    public partial class tbProductosConfiguration : IEntityTypeConfiguration<tbProductos>
    {
        public void Configure(EntityTypeBuilder<tbProductos> entity)
        {
            entity.HasKey(e => e.prod_Id);

            entity.Property(e => e.prod_Codigo)
                .IsRequired()
                .HasMaxLength(7);

            entity.Property(e => e.prod_FechaCrea).HasColumnType("datetime");

            entity.Property(e => e.prod_FechaModifica).HasColumnType("datetime");

            entity.Property(e => e.prod_Nombre)
                .IsRequired()
                .HasMaxLength(150);

            entity.Property(e => e.prod_Precio).HasColumnType("decimal(10, 2)");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<tbProductos> entity);
    }
}
