using eCommerceNet.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace eCommerceNet.Data.Configuration
{
    public partial class ProductoConfiguration
    {
        public void Configure(EntityTypeConfiguration<Producto> entity)
        {
            entity.ToTable("producto");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Nombre);
            entity.Property(e => e.Precio);
            entity.Property(e => e.Fecha);
            entity.Property(e => e.Imagen);

            OnConfigurationPartial(entity);
        }

        partial void OnConfigurationPartial(EntityTypeConfiguration<Producto> entity);
    }
}