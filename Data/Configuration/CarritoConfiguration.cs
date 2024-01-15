using eCommerceNet.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace eCommerceNet.Data.Configuration
{
    public partial class CarritoConfiguration
    {
        public void Configure(EntityTypeConfiguration<Carrito> entity)
        {
            entity.ToTable("carrito");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.IdUsuario);
            entity.Property(e => e.IdProducto);
            entity.Property(e => e.Cantidad);
            entity.HasIndex(e => e.IdUsuarioNavigation);
            entity.HasIndex(e => e.IdProductoNavigation);

            OnConfigurationPartial(entity);
        }

        partial void OnConfigurationPartial(EntityTypeConfiguration<Carrito> entity);
    }
}