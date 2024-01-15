using eCommerceNet.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using System.Web.DynamicData;

namespace eCommerceNet.Data.Configuration
{
    public partial class CantidadProductoConfiguration
    {
        public void Configure(EntityTypeConfiguration<CantidadProducto> entity)
        {
            entity.ToTable("cantidadProducto");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.IdProducto);
            entity.Property(e => e.Cantidad);
            entity.HasIndex(e => e.IdProductoNavigation);

            OnConfigurationPartial(entity);
        }

        partial void OnConfigurationPartial(EntityTypeConfiguration<CantidadProducto> entity);
    }
}