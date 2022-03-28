using Application.Entities.Entities;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;
using Application.DataAccess.DbContextContainer;
#nullable disable

#nullable disable

namespace Application.DataAccess.DbContextContainer
{
    public partial class DBEXAMENContext : DbContext
    {
        public DBEXAMENContext()
        {
        }

        public DBEXAMENContext(DbContextOptions<DBEXAMENContext> options)
            : base(options)
        {
        }

        public virtual DbSet<tbProductos> tbProductos { get; set; }
        public virtual DbSet<tbTipoProductos> tbTipoProductos { get; set; }
        public virtual DbSet<tbUnidadMedidas> tbUnidadMedidas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.ApplyConfiguration(new Application.DataAccess.DbContextContainer.Configurations.tbProductosConfiguration());
            modelBuilder.ApplyConfiguration(new Application.DataAccess.DbContextContainer.Configurations.tbTipoProductosConfiguration());
            modelBuilder.ApplyConfiguration(new Application.DataAccess.DbContextContainer.Configurations.tbUnidadMedidasConfiguration());
            OnModelCreatingGeneratedProcedures(modelBuilder);
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
